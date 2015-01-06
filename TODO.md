###Benji's TODO by Zaaryus

1. Create exe-installer and install it properly.
2. Make the program run in the background.
3. Start running on PC startup.
4. When right-clicking the background-running icon, there should be an option to open the Gyabz UI.
5. The UI should contain some options. (More can be added later)
  * Choose between regionalized or full screenshot.
  * Set key-binding to activate screenshot.
6. Autosave file with a random-generated id. (Just until it uploads to the server)
```bash
Example: fsdJDF345Nd9fs8n3.png
```

=========

###Ideas & Upcoming Features

#####API Endpoint

```bash
POST http://gya.bz/api/shot
```
```bash
DATA key={"user": USERNAME, "access": PC_SPECIFIC_KEY, "data": BASE64_PNG_IMAGE}(BASE64)
```
```bash
RETURNS {"time": TIME_CREATED, "id": SCREENSHOT_ID} on success
```

* USERNAME is self-explanatory.
* PC_SPECIFIC_KEY is a unique generated password when you link your pc to the site.
* BASE64_PNG_IMAGE is the image data in png format encrypted with base64.
* TIME_CREATED is the date/time the image was created.
* SCREENSHOT_ID is the id of the screenshot which is used in the url.

```bash
EXAMPLE SCREENSHOT_ID=fsdJDF345Nd9fs8n3 http://gya.bz/s/+SCREENSHOT_ID
```
