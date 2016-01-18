// Write a script that finds the max and min number from a sequence of numbers.
taskName = "Min/Max of sequence";

function Main(bufferElement) {
// Input
    var seq = [6, 7, 9, 500, 2, 4, 5, 6, 7], // Change value to TEST
        minValue = -9007199254740992,
        maxValue = 9007199254740992,
        min,
        max;
        
    // Solution   
    for (var i = 0; i < seq.length; i++) {
        if (seq[i] < maxValue) {
            maxValue = seq[i];
            min = maxValue;
        }

        if (seq[i] > minValue) {
            minValue = seq[i];
            max = minValue;
        }
    }
// Output
    WriteLine("Sequence: " + seq);
    WriteLine("Min: " + min);
    WriteLine("Max: " + max);
}