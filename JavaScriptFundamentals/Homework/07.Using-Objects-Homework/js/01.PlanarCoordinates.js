/*
 Problem 1. Planar coordinates

 Write functions for working with shapes in standard Planar coordinate system.
 Points are represented by coordinates P(X, Y)
 Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
 Calculate the distance between two points.
 Check if three segment lines can form a triangle.
 */

function firstProblem(){
    var result = document.getElementById('finalAnswer'),
        x1 = document.getElementById('x1').value,
        y1 = document.getElementById('y1').value,
        x2 = document.getElementById('x2').value,
        y2 = document.getElementById('y2').value,
        segmentOneResult = document.getElementById('segmentOneAnswer'),
        firstSegment,
        x3 = document.getElementById('x3').value,
        y3 = document.getElementById('y3').value,
        x4 = document.getElementById('x4').value,
        y4 = document.getElementById('y4').value,
        segmentTwoResult = document.getElementById('segmentTwoAnswer'),
        secondSegment,
        x5 = document.getElementById('x5').value,
        y5 = document.getElementById('y5').value,
        x6 = document.getElementById('x6').value,
        y6 = document.getElementById('y6').value,
        segmentThreeResult = document.getElementById('segmentThreeAnswer'),
        thirdSegment;

    result.innerHTML = '';
    segmentOneResult.innerHTML = '';
    segmentTwoResult.innerHTML = '';
    segmentThreeResult.innerHTML = '';

    if(validDataCheck()){
        var pointOne = createPoint(x1, y1);
        var pointTwo = createPoint(x2, y2);
        var pointThree = createPoint(x3, y3);
        var pointFour = createPoint(x4, y4);
        var pointFive = createPoint(x5, y5);
        var pointSix = createPoint(x6, y6);

        calculateDistance(pointOne, pointTwo);
        firstSegment = createSegment(pointOne, pointTwo);
        segmentOneResult.innerHTML =
            'First Line: Point 1(' + pointOne.x + ', ' + pointOne.y + '), Point 2(' + pointTwo.x + ', ' + pointTwo.y + ') Length: ' + firstSegment.length;
        console.log('Segment 1: Point 1(' + pointOne.x + ', ' + pointOne.y + '), Point 2(' + pointTwo.x + ', ' + pointTwo.y + ') Length: ' + firstSegment.length);

        calculateDistance(pointThree, pointFour);
        secondSegment = createSegment(pointThree, pointFour);
        segmentTwoResult.innerHTML =
            'Second Line: Point 3(' + pointThree.x + ', ' + pointThree.y + '), Point 4(' + pointFour.x + ', ' + pointFour.y + ') length: ' + secondSegment.length;
        console.log('Second Line: Point 3(' + pointThree.x + ', ' + pointThree.y + '), Point 4(' + pointFour.x + ', ' + pointFour.y + ') length: ' + secondSegment.length);


        calculateDistance(pointFive, pointSix);
        thirdSegment = createSegment(pointFive, pointSix);
        segmentThreeResult.innerHTML =
            'Segment 3: p5(' + pointFive.x + ', ' + pointFive.y + '), p6(' + pointSix.x + ', ' + pointSix.y + ') Length: ' + thirdSegment.length;
        console.log('Segment 3: p5(' + pointFive.x + ', ' + pointFive.y + '), p6(' + pointSix.x + ', ' + pointSix.y + ') Length: ' + thirdSegment.length);

        result.innerHTML =
            '<br/>' + 'CONCLUSION:' + '<br/>' + 'Can the lines form a triangle of some sort? - ' + canFormTriangle(firstSegment, secondSegment, thirdSegment);
        console.log('<br/>' + 'CONCLUSION:' + '<br/>' + 'Can the lines form a triangle of some sort? - ' + canFormTriangle(firstSegment, secondSegment, thirdSegment));
    }
    else{
        result.innerHTML += 'Wrong Input Data!';
        console.log('Wrong Input Data!');
    }
}

function validDataCheck(){
    var index;
    for(index = 1; index <= 6; index += 1){
        if(document.getElementById('x' + index).value == ''
            || document.getElementById('y' + index).value == ''
            || isNaN(document.getElementById('x' + index).value)
            || isNaN(document.getElementById('y' + index).value)
            || !document.getElementById('x' + index).value.match(/\S/)
            || !document.getElementById('y' + index).value.match(/\S/)){

            return false;
        }
    }

    return true;
}

function createPoint(x, y) {
    return {
        'x': x,
        'y': y
    };
}

function createSegment(point1, point2) {
    return {
        'length': calculateDistance(point1, point2)
    };
}

function calculateDistance(point1, point2) {
    return Math.sqrt((point1.x - point2.x) * (point1.x - point2.x) +
        (point1.y - point2.y) * (point1.y - point2.y));
}

function canFormTriangle(sideA, sideB, sideC) {
    if ((sideA.length + sideB.length > sideC.length) &&
        (sideA.length + sideC.length > sideB.length) &&
        (sideB.length + sideC.length > sideA.length)) {
        return true;
    } else {
        return false;
    }
}

