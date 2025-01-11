using QRCoder;
using SkiaSharp;

// Open source library to handle QR Code generation

namespace QRCodeGeneratorLib;

public class QRCodeGeneratorTool
{
    private readonly string defaultDirectory;

    public QRCodeGeneratorTool()
    {
        var userPicturesFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        defaultDirectory = Path.Combine(userPicturesFolder, "QR Codes");

        if (!Directory.Exists(defaultDirectory)) Directory.CreateDirectory(defaultDirectory);
    }

    /// <summary>
    ///     Generates a QR code image from the provided text.
    /// </summary>
    /// <param name="text">The text to encode into the QR code.</param>
    /// <param name="outputFilePath">
    ///     The file path where the QR code image will be saved. If null or empty, it will use the
    ///     default path.
    /// </param>
    /// <param name="pixelsPerModule">The size of each module in the QR code. Default is 20.</param>
    /// <param name="foregroundColor">The foreground color of the QR code. Default is black.</param>
    /// <param name="backgroundColor">The background color of the QR code. Default is transparent.</param>
    /// <param name="logoFilePath">Optional file path to a logo image to embed in the center of the QR code.</param>
    /// <returns>Returns true if the QR code was successfully generated and saved, otherwise false.</returns>
    public bool GenerateQRCode(string text, string? outputFilePath = null, int pixelsPerModule = 20,
        SKColor? foregroundColor = null, SKColor? backgroundColor = null, string? logoFilePath = null,
        QRCodeGenerator.ECCLevel errorCorrectionLevel = QRCodeGenerator.ECCLevel.L)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException("Input text cannot be null or empty.", nameof(text));

            if (string.IsNullOrWhiteSpace(outputFilePath))
            {
                var fileName = $"QRCode_{DateTime.Now:yyyyMMdd_HHmmss}.png";
                outputFilePath = Path.Combine(defaultDirectory, fileName);
            }

            // Set default colors if not provided
            var fgColor = foregroundColor ?? SKColors.Black;
            var bgColor = backgroundColor ?? SKColors.Transparent;

            using (var qrGenerator = new QRCodeGenerator())
            {
                var qrCodeData = qrGenerator.CreateQrCode(text, errorCorrectionLevel);

                using (var surface = SKSurface.Create(new SKImageInfo(pixelsPerModule * qrCodeData.ModuleMatrix.Count,
                           pixelsPerModule * qrCodeData.ModuleMatrix.Count)))
                {
                    var canvas = surface.Canvas;
                    canvas.Clear(bgColor);

                    for (var x = 0; x < qrCodeData.ModuleMatrix.Count; x++)
                    for (var y = 0; y < qrCodeData.ModuleMatrix[x].Count; y++)
                        if (qrCodeData.ModuleMatrix[x][y])
                            canvas.DrawRect(
                                new SKRect(x * pixelsPerModule, y * pixelsPerModule, (x + 1) * pixelsPerModule,
                                    (y + 1) * pixelsPerModule), new SKPaint { Color = fgColor });

                    if (!string.IsNullOrWhiteSpace(logoFilePath) && File.Exists(logoFilePath))
                        using (var logoBitmap = SKBitmap.Decode(logoFilePath))
                        {
                            var logoSize =
                                pixelsPerModule * qrCodeData.ModuleMatrix.Count / 5; // Logo size is 1/5th of QR code
                            var logoX = (pixelsPerModule * qrCodeData.ModuleMatrix.Count - logoSize) / 2;
                            var logoY = (pixelsPerModule * qrCodeData.ModuleMatrix.Count - logoSize) / 2;

                            canvas.DrawBitmap(logoBitmap, new SKRect(logoX, logoY, logoX + logoSize, logoY + logoSize));
                        }

                    using (var image = surface.Snapshot())
                    using (var data = image.Encode(SKEncodedImageFormat.Png, 100))
                    using (var stream = File.OpenWrite(outputFilePath))
                    {
                        data.SaveTo(stream);
                    }
                }
            }

            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error generating QR Code: {ex.Message}");
            return false;
        }
    }

    /// <summary>
    ///     Generates a QR code for a hyperlink.
    /// </summary>
    /// <param name="url">The hyperlink to encode into the QR code.</param>
    /// <param name="outputFilePath">
    ///     The file path where the QR code image will be saved. If null or empty, it will use the
    ///     default path.
    /// </param>
    /// <param name="pixelsPerModule">The size of each module in the QR code. Default is 20.</param>
    /// <param name="foregroundColor">The foreground color of the QR code. Default is black.</param>
    /// <param name="backgroundColor">The background color of the QR code. Default is transparent.</param>
    /// <param name="logoFilePath">Optional file path to a logo image to embed in the center of the QR code.</param>
    /// <returns>Returns true if the QR code was successfully generated and saved, otherwise false.</returns>
    public bool GenerateHyperlinkQRCode(string url, string? outputFilePath = null, int pixelsPerModule = 20,
        SKColor? foregroundColor = null, SKColor? backgroundColor = null, string? logoFilePath = null,
        QRCodeGenerator.ECCLevel errorCorrectionLevel = QRCodeGenerator.ECCLevel.L)
    {
        if (Uri.TryCreate(url, UriKind.Absolute, out _))
            return GenerateQRCode(url, outputFilePath, pixelsPerModule, foregroundColor, backgroundColor, logoFilePath);

        Console.WriteLine("Invalid URL format.");
        return false;
    }

    /// <summary>
    ///     Generates a QR code for a contact card.
    /// </summary>
    /// <param name="firstName">First name of the contact.</param>
    /// <param name="lastName">Last name of the contact.</param>
    /// <param name="organization">Organization or company name.</param>
    /// <param name="phone">Phone number.</param>
    /// <param name="email">Email address.</param>
    /// <param name="outputFilePath">
    ///     The file path where the QR code image will be saved. If null or empty, it will use the
    ///     default path.
    /// </param>
    /// <param name="pixelsPerModule">The size of each module in the QR code. Default is 20.</param>
    /// <param name="foregroundColor">The foreground color of the QR code. Default is black.</param>
    /// <param name="backgroundColor">The background color of the QR code. Default is transparent.</param>
    /// <param name="logoFilePath">Optional file path to a logo image to embed in the center of the QR code.</param>
    /// <returns>Returns true if the QR code was successfully generated and saved, otherwise false.</returns>
    public bool GenerateContactCardQRCode(string firstName, string lastName, string organization, string phone,
        string email, string? outputFilePath = null, int pixelsPerModule = 20, SKColor? foregroundColor = null,
        SKColor? backgroundColor = null, string? logoFilePath = null,
        QRCodeGenerator.ECCLevel errorCorrectionLevel = QRCodeGenerator.ECCLevel.L)
    {
        var vCard = $"BEGIN:VCARD\nVERSION:3.0\n" +
                    $"N:{lastName};{firstName};;;\n" +
                    $"FN:{firstName} {lastName}\n" +
                    (string.IsNullOrWhiteSpace(organization) ? "" : $"ORG:{organization}\n") +
                    (string.IsNullOrWhiteSpace(phone) ? "" : $"TEL;WORK;VOICE:{phone}\n") +
                    (string.IsNullOrWhiteSpace(email) ? "" : $"EMAIL:{email}\n") +
                    "END:VCARD";

        return GenerateQRCode(vCard, outputFilePath, pixelsPerModule, foregroundColor, backgroundColor, logoFilePath);
    }

    /// <summary>
    ///     Generates a QR code for a calendar event.
    /// </summary>
    /// <param name="eventName">Name of the event.</param>
    /// <param name="startTime">Start time of the event in UTC.</param>
    /// <param name="endTime">End time of the event in UTC.</param>
    /// <param name="location">Location of the event.</param>
    /// <param name="description">Description of the event.</param>
    /// <param name="outputFilePath">
    ///     The file path where the QR code image will be saved. If null or empty, it will use the
    ///     default path.
    /// </param>
    /// <param name="pixelsPerModule">The size of each module in the QR code. Default is 20.</param>
    /// <param name="foregroundColor">The foreground color of the QR code. Default is black.</param>
    /// <param name="backgroundColor">The background color of the QR code. Default is transparent.</param>
    /// <param name="logoFilePath">Optional file path to a logo image to embed in the center of the QR code.</param>
    /// <returns>Returns true if the QR code was successfully generated and saved, otherwise false.</returns>
    public bool GenerateEventQRCode(string eventName, DateTime startTime, DateTime endTime, string location,
        string description, string? outputFilePath = null, int pixelsPerModule = 20, SKColor? foregroundColor = null,
        SKColor? backgroundColor = null, string? logoFilePath = null,
        QRCodeGenerator.ECCLevel errorCorrectionLevel = QRCodeGenerator.ECCLevel.L)
    {
        var eventDetails = $"BEGIN:VEVENT\n" +
                           $"SUMMARY:{eventName}\n" +
                           $"DTSTART:{startTime:yyyyMMddTHHmmssZ}\n" +
                           $"DTEND:{endTime:yyyyMMddTHHmmssZ}\n" +
                           (string.IsNullOrWhiteSpace(location) ? "" : $"LOCATION:{location}\n") +
                           (string.IsNullOrWhiteSpace(description) ? "" : $"DESCRIPTION:{description}\n") +
                           "END:VEVENT";

        return GenerateQRCode(eventDetails, outputFilePath, pixelsPerModule, foregroundColor, backgroundColor,
            logoFilePath);
    }

    /// <summary>
    ///     Generates a QR code for a social media profile or post.
    /// </summary>
    /// <param name="platform">The social media platform.</param>
    /// <param name="usernameOrURL">The username or direct URL to the profile/post.</param>
    /// <param name="outputFilePath">
    ///     The file path where the QR code image will be saved. If null or empty, it will use the
    ///     default path.
    /// </param>
    /// <param name="pixelsPerModule">The size of each module in the QR code. Default is 20.</param>
    /// <param name="foregroundColor">The foreground color of the QR code. Default is black.</param>
    /// <param name="backgroundColor">The background color of the QR code. Default is transparent.</param>
    /// <param name="logoFilePath">Optional file path to a logo image to embed in the center of the QR code.</param>
    /// <returns>Returns true if the QR code was successfully generated and saved, otherwise false.</returns>
    public bool GenerateSocialMediaQRCode(SocialMediaPlatform platform, string usernameOrURL,
        string? outputFilePath = null, int pixelsPerModule = 20, SKColor? foregroundColor = null,
        SKColor? backgroundColor = null, string? logoFilePath = null,
        QRCodeGenerator.ECCLevel errorCorrectionLevel = QRCodeGenerator.ECCLevel.Default)
    {
        if (string.IsNullOrWhiteSpace(usernameOrURL))
        {
            Console.WriteLine("Username/URL cannot be empty.");
            return false;
        }

        string socialMediaURL;
        if (Uri.TryCreate(usernameOrURL, UriKind.Absolute, out _))
            socialMediaURL = usernameOrURL;
        else
            socialMediaURL = platform switch
            {
                SocialMediaPlatform.Facebook => $"https://www.facebook.com/{usernameOrURL}",
                SocialMediaPlatform.Twitter => $"https://twitter.com/{usernameOrURL}",
                SocialMediaPlatform.Instagram => $"https://www.instagram.com/{usernameOrURL}",
                SocialMediaPlatform.LinkedIn => $"https://www.linkedin.com/in/{usernameOrURL}",
                SocialMediaPlatform.YouTube => $"https://www.youtube.com/{usernameOrURL}",
                _ => throw new ArgumentException($"Unsupported platform: {platform}")
            };

        return GenerateQRCode(socialMediaURL, outputFilePath, pixelsPerModule, foregroundColor, backgroundColor,
            logoFilePath);
    }
}