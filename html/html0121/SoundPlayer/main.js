// javaScript는 큰 따옴표와 작은 따옴표 모두 문장 정의에 사용됨

// window 객체는 웹브라우저 전체를 의미한다고 보면 됨
// 많이 쓰이는 건 document 객체를 많이 씀


// jsQuery로 변경

$(document).ready(function () { //jQ    
    // window.addEventListener('load',
    //     function () {
    // alert("Sounds");

    // 클래스명이 sound인 것을 모두 불러옴(=선택함)
    const sounds = $(".sound");

    // 클래스명이 pads인 태그의 후손 중에서 div태그들 모두 불러옴
    const pads = $(".pads div");

    // 클래스명이 visual인 태그 하나 선택
    const visual = $('.visual');

    // 클래스명이 title인 태그 하나 선택
    const title = $('.title');

    // 초기화할 때 쓰임
    const colors = ["lightsalmon", "lemonchiffon", "rgba(56, 192, 185, 0.822)",
        "rgba(44, 149, 253, 0.74)", "rgba(149, 238, 149, 0.87)", "pink"
    ];

    // 재생되는 음악이 끝나면, .visual에서 비주얼과 제목 제거
    // sounds.forEach(function (snd) {
    //     snd.onended = function () {
    //         visual.innerHTML = "";
    //         title.innerHTML = "";
    //     };
    // });

    sounds.each(function (index, soundFile) { // index : 번호 선택자
        soundFile.onended = function () {
            // visual.innerHTML = "";
            visual.text('');
            // title.innerHTML = "";
            title.text('');

            // 참고
            // 값 읽을 때 : 빈 괄호
            // var test = visual.text();

            // 값 쓸 때 : 괄호 안에 내용 삽입
            // visual.text('aaa');
        }
    });

    // pads.forEach(function (pad, index) { // js
    pads.each(function (index, pad) { // jQ
        // pad.addEventListener('click', function () { // js
        $(pad).on('click', function () { // jQs
            // 클래스명이 sound인 태그들 각각에 대하여
            // sounds.forEach(function (inx) {
            sounds.each(function (inx, sndf) {
                sndf.pause();            
            // console.log(inx);
            // 기존에 재생되는 소리를 모두 정지시킴
            // inx.pause();
        });
        if (sounds[index]) {
            sounds[index].currentTime = 0;
            sounds[index].play();

            const strArray = sounds[index].src.split("sound/");
            console.log(strArray[0]);
            console.log(strArray[1]);
            // title.innerHTML = strArray[1];//js
            title.text(strArray[1]); //jQ
        }

        // 볼 만들고 애니메이션 하기
        createBubbles(index);
    });
});

const createBubbles = function (index) {
    // visual.innerHTML = "";
    visual.text('');

    /* javaScript 
    // div 태그 생성
    const bubble = document.createElement("div");
    // visual 태그 안에 div 태그 하나 집어넣음
    visual.appendChild(풍선껌);
    bubble.style.backgroundColor = colors[index];
    bubble.style.top = '300px';
    // animation 관련된 건 html책 참고
    bubble.style.animation = 'animation 2000ms linear infinite both';
    */


    const bubble = $("<div></div>");
    visual.append(bubble);
    bubble.css('background', colors[index]).css('top', '300px').css('animation', 'animation 2000ms linear infinite both')
}

}

);