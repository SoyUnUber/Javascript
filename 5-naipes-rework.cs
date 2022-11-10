<!DOCTYPE html>
<html>
<head>
<title>Page Title</title>
</head>
<style>
    body {
        background: #292929;
        align-items: center;
        display: flex;
        justify-content: center;
        height: 100vh;   
    }

    .cartabox {
        perspective: 500px;
     margin: 15px;
     

    }
    .carta{
        position: relative;
        width: 250px;
        height: 390px;
        background: #fff;
        transform-style: preserve-3d;
        transition: .5s ease;
        box-shadow: 0 30px 30px rgba(0, 0, 0, .5);
    }

    .cartafrontal , .cartatrasera {
        position: absolute;
        top: 0;
        left: 0;
        width: 150px;
        height: 150px;
        color: #fff;
        backface-visibility: hidden;

    }

    .cartafrontal
    {
        font-size: 40px;
        justify-content: center;
        text-align: center;

    }

    .cartabox:hover .carta
    {
        transform: rotateY(180deg);
        background-image: url("https://media.discordapp.net/attachments/1023209489291292704/1040285550759903313/As_trebol_1_1.png");
    }

.cartatrasera
{
    transform: rotateY(180deg);
}
    
    
</style>
<body>
 
<div class="cartabox">
    <div class="carta">
        <div class="cartafrontal"></div>
        <div class="cartatrasera">cartaa</div>
    </div>
</div>

<div class="cartabox">
    <div class="carta">
        <div class="cartafrontal"></div>
        <div class="cartatrasera">cartaa</div>
    </div>
</div>

<div class="cartabox">
    <div class="carta">
        <div class="cartafrontal"></div>
        <div class="cartatrasera">carta</div>
    </div>
</div>


</body>
</html>
