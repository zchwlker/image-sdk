
// See https://aka.ms/new-console-template for more information
using ImageMetricsLib;

var check = await SdkLicenseService.InitializeLicensing("demo.bin");
Console.WriteLine(check);
ImageMetricsCalc metic = new ImageMetricsCalc();
//byte[] imageBytes = File.ReadAllBytes("sun.jpg");
//var test = metic.CalculateClarity(imageBytes);
//Console.WriteLine(test);