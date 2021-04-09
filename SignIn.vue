<template>
  <article>
    <div class="container">
      <form class="login" action="#">
        <input type="email" placeholder="Email" />
        <input type="password" placeholder="Password"/>
        <button class="login">Log In</button>
        <hr class="hr-text" data-content="Or">
        <button class="facebook">Continue with Facebook</button>
        <button class="google">Continue with Google</button>
      </form>
      
    </div>
  </article>
</template>
<script>
  
  export default {
    
  }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped lang="scss">
  .container{
    position: relative;
    overflow: hidden;
    box-shadow: 0 15px 30px rgba(0, 0, 0, 0.2),
                0 10px 10px rgba(0, 0, 0, .2);
    border-radius: 25px;
    background: linear-gradient(to bottom, #f1dbee,#f1dbee);
    width: 500px;
    height: 500px;
    
  }
  .hr-text {
    margin-top: 0px;
    line-height: 1em;
    position: relative;
    outline: 0;
    border: 0;
    color: black;
    text-align: center;
    height: 1.5em;
    width: 150px;
    opacity: .5;
    &:before {
      content: '';
    // use the linear-gradient for the fading effect
    // use a solid background color for a solid bar
      background: black;
      position: absolute;
      left: 0;
      top: 50%;
      width: 100%;
      height: 1px;
    }
    &:after {
      content: attr(data-content);
      position: relative;
      display: inline-block;
      color: black;

      padding: 0 .5em;
      line-height: 1.5em;
      // this is really the only tricky part, you need to specify the background color of the container element...
      color: #252525;
      background-color: #f1dbee;
    }
  }
  button.login{
    border-radius: 20px;
    border:1px solid #000000;
    background-color: #9932CC;
    color: #ffff;
    font-size: 1rem;
    font-weight: bold;
    padding: 10px 40px;
    letter-spacing: 1px;
    letter-spacing: 1px;
    background-image: url('/assets/fb.jpg');
    &:active{
      transform: scale(.9);
    }

    &:focus{
      outline: none;
    }
  }
  button.facebook{
    border-radius: 20px;
    border:1px solid #000000;
    background-color: #ffffff;
    color:gray;
    font-size: 1rem;
    font-weight: bold;
    padding: 10px 40px;
    letter-spacing: 1px;
    letter-spacing: 1px;
    
    &:active{
      transform: scale(.9);
    }

    &:focus{
      outline: none;
    }
  }
  button.google{
    border-radius: 20px;
    border:1px solid #000000;
    background-color: #ffffff;
    color:gray;
    font-size: 1rem;
    font-weight: bold;
    padding: 10px 40px;
    letter-spacing: 1px;
    letter-spacing: 1px;
    &:active{
      transform: scale(.9);
    }

    &:focus{
      outline: none;
    }
  }
  form{
    position:relative;
    top: 0;
    display: flex;
    align-items: center;
    justify-content: space-around;
    flex-direction: column;
    padding: 150px 60px;
    text-align: center;

    input{
      padding: 8px 15px;
      border-radius: 10px;
      width: 350px;
      border: none;
      margin: 10px;
      overflow: hidden;
     
      &:focus{
        outline: none;
        
      }
    }
    button.login{
      border-color: black;
      margin: 10px;
      width: 400px;
    }
    
    button.facebook{
      border-color: black;
      margin: 10px;
      width: 300px;
      

    }

    button.google{
      border-color: black;
      margin: 10px;
      width: 300px;
    }
    
  }
</style>
