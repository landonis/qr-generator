# qr-generator
Windows 10 App for generating QR codes

# Note
This Application was designed with the intent of gaining personal experience using .NET MAUI, creating system processes, and running compiled python executables inside of a .net package.
The QR Generation is done with an executable created using auto-py-to-exe and the python package for generating the qr codes can be referenced at: [python-qrcode](https://github.com/lincolnloop/python-qrcode,"github.com/lincolnloop/python-qrcode")

# Installing QR Generator
Pull the install-package from latest release and follow README instructions [install here](https://github.com/landonis/qr-generator/releases/tag/package)
Install the .msix and the certificate to install the application.

# Using the App

![main page](https://github.com/landonis/qr-generator/blob/MD-Asset/0.0.1.screenshots/main.png)

The Application requires all of the attribute fields to be filled. It will overwrite any file with the same name inside of the output folder, so for multiple codes be sure to rename the file and use a .png extension. 
When you are ready to export, you can hit view to open your default image viewer or use the open → output folder button.
![main page](https://github.com/landonis/qr-generator/blob/MD-Asset/0.0.1.screenshots/output.png)
