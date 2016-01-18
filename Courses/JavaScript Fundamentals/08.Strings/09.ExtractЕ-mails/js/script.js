// Write a function for extracting all email addresses from given text.
// All sub-strings that match the format @… should be recognized as emails.
// Return the emails as array of strings.
taskName = "Extract e-mails";

function Main(bufferElement) {
// Input
    var text = 'Hi Kolega,' + // Change value to TEST
    'Just wanted to thank you for checking my homework. ' +
    'This is example text with emails sample@mail.bg ' +
    'and other emails like this email@gmail.com, academy@telerik.com ' +
    'Have a nice day!'; 
// Solution   
    function extractEmail(text) {
        var findEmails = text.match(/\w*@\w*\.\w*/g);

        return findEmails;
    }
    // Output
    WriteLine("Text: " + text);
    WriteLine();
    WriteLine("Emails in text: " + extractEmail(text).join(", "));
}