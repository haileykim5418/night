window.addEventListener('load',
        function () {
            //alert('모야')
            const sounds = document.querySelectorAll(".sound");
            const pads = document.querySelectorAll(".pads div");
            //클래스 이름이 visual인 태그 하나 선택
            const visual = document.querySelector(".visual");
            //클래스 이름이 title인 태그 하나 선택
            const title = document.querySelector(".title");

            //초기화 할때 쓰임
            const colors = ['lightcyan', 'lightgray', 'lightgreen', 'lightseagreen', 'lightsalmon', 'lightgoldenrodyellow'];

            //재생되는 음악이 끝나면 비주얼에서 비주얼과 제목 제거

               sounds.forEach(snd => {
                snd.onended = function(){
                    visual.innerHTML = "";
                    title.innerHTML = "";
                };
            });

            // pads.forEach((pad, index) => {
            //     pad.addEventListener('click', function(){
            //         //기존에 재생되는 음악을 중지 시켜야 한다.
            //        sounds.forEach(inx => {
            //         //console.log(inx);
            //         inx.pause();
            //        });
            //     });
            //        if(sounds[index]){
            //         sounds[index].currentTime = 0;
            //         sounds[index].play();

            //         //뮤직 제목을 출력해 준다.
            //         //console.log(sounds[index].src) ;
            //         const strArray = sounds[index].src.split("sound/");
            //         title.innerHTML = strArray[1];
            //        }
                   
            //         //볼만들고 애니메이션 하기
            //         //createBubbles(index);
            //     });
            pads.forEach( function(pad, index) {
                pad.addEventListener('click', function(){
                    //기존에 재생되는 음악을 중지 시켜야 한다.
                   sounds.forEach(function(inx) {
                    //console.log(inx);
                    inx.pause();
                   });
                   if(sounds[index]){
                    sounds[index].currentTime = 0;
                    sounds[index].play();
    
                    //뮤직 제목을 출력해 준다.
                    //console.log(sounds[index].src) ;
                    const strArray = sounds[index].src.split("sound/");
                    title.innerHTML = strArray[2];
                    console.log(strArray);
                   }
                   
                    // 볼만들고 애니메이션 하기
                    createBubbles(index);
                });
            });
          
            const createBubbles = function(index)
            {
                visual.innerHTML = "";
                const bubble = document.createElement("div");
                visual.appendChild(bubble);
                bubble.style.backgroundColor = colors[index];
                bubble.style.top = '300px';
                bubble.style.animation = 'animation 2000ms linear infinite both';
            }
});
