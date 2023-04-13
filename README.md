### About this Dalamud Staging and Beta information parsing helper utility:

This simple console app/script will parse the latest Dalamud Staging information necessary to enable Beta access, and afterwards ask if the user wants to open their dalamudConfig.json file with a simple **y/N** prompt. This is so the user can manually make the necessary changes, this tool will **not** automatically enable beta access in any way, that still having to be done by any would be user at their own risk and responsability, on how to do that check the Dalamud documentation and follow their instructions.

Official documentation on how to use the DalamudBetaKey and access Staging Builds can be found <a href="https://goatcorp.github.io/faq/dalamud_troubleshooting.html#:~:text=Go%20to%20%25AppData%25%5CXIVLauncher,quotes)%20to%20disable%20Dalamud%20Staging.">here</a>.




###### This application is very simple and rudimentary, it was intended to be used in Windows only.

##### Dalamud developers stance and warning about Staging Builds:
> This is for developers, not users. Plugin testers should only use it when specifically stated. You should expect to encounter issues and crash more often on staging builds. Use with caution.
##### Please use it responsibly. <br> <br>


### Preview:
![WindowsTerminal_Owm8p37yRX](https://user-images.githubusercontent.com/39604793/226851797-94ac6563-f9f1-45b7-a15e-d12ac96f0535.png)
###### *Yes. It is that simple, not even a colored output. Key was blanked for screenshot purposes.*

### How To Use:
* Just download the [executable from the latest release](link) and run it.
<br> It doesn't have to run as with administrative powers. Since this isn't a popular/signed file there will be warnings before you can run it.
You can safely ignore these and allow it to run.

• Or you can clone the repository locally and build and run it yourself with `dotnet run` or by forking the repository and building with GitHub actions after checking the code if you'd like.
<br> This is honestly a very simple and compact piece of code, should be easy to audit for those that want to, and I appreciate that as well.
