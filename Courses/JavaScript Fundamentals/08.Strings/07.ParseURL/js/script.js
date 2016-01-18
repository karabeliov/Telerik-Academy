// Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
// Return the elements in a JSON object.
taskName = "Parse URL";

function Main(bufferElement) {
    // Input
    var url = "http://telerikacademy.com/Courses/Courses/Details/239"; // Change value to TEST
    // Solution   
    function parseURL(url) {
        var startIndexProtocol = 0,
            endIndexProtocol = url.indexOf("://", startIndexProtocol),
            startServer = endIndexProtocol + 3,
            endServer = url.indexOf("/", startServer),
            startResorce = endServer,
            endResorce = url.length;

        var json = {
            "protocol": url.substring(startIndexProtocol, endIndexProtocol),
            "server": url.substring(startServer, endServer),
            "resource": url.substring(startResorce, endResorce)
        }

        return json;
    }
    // Output
    var jsonObject = parseURL(url);
    WriteLine("URL: " + url);
    WriteLine("Protocol: " + jsonObject.protocol);
    WriteLine("Server: " + jsonObject.server);
    WriteLine("Resorce: " + jsonObject.resource);
}