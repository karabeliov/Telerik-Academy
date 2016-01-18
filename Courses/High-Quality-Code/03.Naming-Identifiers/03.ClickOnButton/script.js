function checkBrowserIsMozilla(event, arguments) {
    var element = window,
        browser = element.navigator.appCodeName,
        isMozilla = browser == "Mozilla";

    if (isMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}