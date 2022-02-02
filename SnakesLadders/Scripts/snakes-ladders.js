function roll(playerIndex) {
    var request = new XMLHttpRequest();
    request.addEventListener('load', (evt) => {
        response = JSON.parse(request.response);
        var pawn = document.querySelector('.board .player[data-player="' + playerIndex + '"]');
        var moves = response.Item1;
        var current = 0;

        move();

        if (response.Item2) {
            document.querySelector('#winner').innerHTML = (playerIndex + 1);
            document.querySelector('.end').classList.add('ended');
        }

        function getRow(position) {
            return Math.floor(position / 10) + 1;
        }
        // Odd rows are left-to-right. Even rows are right-to-left.
        function getCol(position) {
            return (getRow(position) % 2) == 0 ? 10 - (position % 10) : (position % 10) + 1;
        }
        function move() {
            var row = getRow(moves[current]);
            var col = getCol(moves[current]);
            pawn.classList.remove('col-' + col);
            pawn.classList.remove('row-' + row);
            current++;
            row = getRow(moves[current]);
            col = getCol(moves[current]);
            pawn.classList.add('col-' + col);
            pawn.classList.add('row-' + row);
            if (current < moves.length - 1) {
                setTimeout(move, 1000);
            }
        }
    });
    request.open('GET', '/Home/Move/' + playerIndex);
    request.send();
}