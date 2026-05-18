# VintaSoft WinForms DICOM MPR Viewer Demo

This C# project uses <a href="https://www.vintasoft.com/vsimaging-dotnet-index.html">VintaSoft Imaging .NET SDK</a> and demonstrates how to view DICOM MPR in WinForms:
* Create and view 3D multiplanar reconstruction of DICOM images.
* Create and view 2D multiplanar reconstruction of DICOM images.


## Screenshot
<img src="vintasoft-dicom-mpr-viewer-demo.png" title="VintaSoft DICOM MPR Viewer Demo">


## Usage
1. Get the 30 day free evaluation license for <a href="https://www.vintasoft.com/vsimaging-dotnet-index.html" target="_blank">VintaSoft Imaging .NET SDK</a> here: <a href="https://myaccount.vintasoft.com/user/getEvaluationLicense" target="_blank">https://myaccount.vintasoft.com/user/getEvaluationLicense</a>

2. Update the evaluation license in "CSharp\MainForm.cs" file:
   ```
   Vintasoft.Imaging.ImagingGlobalSettings.Register("REG_USER", "REG_EMAIL", "EXPIRATION_DATE", "REG_CODE");
   ```

3. Build the project ("DicomMprViewerDemo.Net10.csproj" file) in Visual Studio or using .NET CLI:
   ```
   dotnet build DicomMprViewerDemo.Net10.csproj
   ```

4. Run compiled application and try to view DICOM MPR.


## Documentation
VintaSoft Imaging .NET SDK on-line User Guide and API Reference for .NET developer is available here: https://www.vintasoft.com/docs/vsimaging-dotnet/


## Support
Please visit our <a href="https://myaccount.vintasoft.com/">online support center</a> if you have any question or problem.
