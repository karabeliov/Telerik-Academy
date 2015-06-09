taskName = "Horsy";

function Main(bufferElement) {
// Input
    var test1 = [
         '3 85',
         '4228545871361134531572665621474876581741275177843485425355845655786786648413761278158',
         '1181657584763731717511721264164454722344645442681745185234814452255462867574787853385',
         '7463838874877143724175233317747581136752233532656667528668843246726138585172833761417'
    ], test2 = [
         '3 170',
         '65256624788315872547146742545371652845427473747267157662731442588248254733848315117257871124376782841157534346443612618725181711166757567365663638423518322167414635742267',
         '45455813336725247538881424621676377742372315377756873812547467266271517642434424316613753727845166781146278516761172147847651254585283744475617153481423232871713755726637',
         '61554736574112247245452874872314627642462447345828387664685574613831561533388314718463335155846275353167535228183566874387343281726347481161154526852575881675721325662347'
    ], result1 = 'Go go Horsy! Collected 1 weeds',
       result2 = 'Sadly the horse is doomed in 7 jumps';
// Solution   
    function solve(args) {
        var line1 = args[0].split(' '),
            rows = line1[0],
            cols = line1[1],
            row = rows - 1,
            col = cols - 1,
            direction = {
                m1: {
                    row: -2,
                    col: 1
                },
                m2: {
                    row: -1,
                    col: 2
                },
                m3: {
                    row: 1,
                    col: 2
                },
                m4: {
                    row: 2,
                    col: 1
                },
                m5: {
                    row: 2,
                    col: -1
                },
                m6: {
                    row: 1,
                    col: -2
                },
                m7: {
                    row: -1,
                    col: -2
                },
                m8: {
                    row: -2,
                    col: -1
                }
            },
            field = args.slice(1).map(function (line) {
                return line;
            }),
            sum = 0,
            lastMove = 0,
            visited = {},
            key,
            result;

        while (true) {
            debugger;
            // check GO
            if (row < 0 || col < 0 || row >= rows || col >= cols) {
                return 'Go go Horsy! Collected ' + sum + ' weeds';
            }
            // check JUMPS
            if (visited[key]) {
                return 'Sadly the horse is doomed in ' + (lastMove - 1) + ' jumps';
            }
            
            visited[key] = true;
            key = row + ';' + col;

            sum += getValue(row, col);
            // update move
            switch (+field[row][col]) {
                case 1:
                    row += direction.m1.row;
                    col += direction.m1.col;
                    break;
                case 2:
                    row += direction.m2.row;
                    col += direction.m2.col;
                    break;
                case 3:
                    row += direction.m3.row;
                    col += direction.m3.col;
                    break;
                case 4:
                    row += direction.m4.row;
                    col += direction.m4.col;
                    break;
                case 5:
                    row += direction.m5.row;
                    col += direction.m5.col;
                    break;
                case 6:
                    row += direction.m6.row;
                    col += direction.m6.col;
                    break;
                case 7:
                    row += direction.m7.row;
                    col += direction.m7.col;
                    break;
                case 8:
                    row += direction.m8.row;
                    col += direction.m8.col;
                    break;
            }

            lastMove += 1;
        }

        function getValue(row, col) {
            return (1 << row) - col;
        }
    }
// Output
    // WriteLine("TEST1: " + solve(test1));
    WriteLine("TEST2: " + solve(test2));
}