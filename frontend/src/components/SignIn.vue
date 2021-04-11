<template>
  <article>
    <div class="container">
      <form class="login" action="#">
        <input type="email" placeholder="Email" />
        <input type="password" placeholder="Password"/>
        <button class="login">Log In</button>
        <hr class="hr-text" data-content="Or">
        <button class="facebook"><img src="~@/assets/fb.jpg" width="20" height="20" style="float:left">Continue with Facebook</button>
        <button class="google"><img src="~@/assets/google.jpg" width="20" height="20" style="float:left;margin-right:0.5em">Continue with Google</button>
        <a href="#">Forgot password?</a>
      </form>
    </div>
    <div class="container_bottom">
      <p>Don't have an account? <a href="#"><Strong>Sign up</Strong></a>
      </p>
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
    /*box-shadow: 0 15px 30px rgba(0, 0, 0, 0.2),
                0 10px 10px rgba(0, 0, 0, .2); */
    border-radius: 25px;
    background: linear-gradient(to bottom, #f1dbee,#f1dbee);
    width: 500px;
    height: 500px;
  }
  
  .container_bottom{
    margin-top: 20px;
    position: relative;
    overflow: hidden;
    /*box-shadow: 0 15px 30px rgba(0, 0, 0, 0.2),
                0 10px 10px rgba(0, 0, 0, .2); */
    border-radius: 25px;
    background: linear-gradient(to bottom, #f1dbee,#f1dbee);
    width: 500px;
    height: 50px;
    p{
      text-align: center;
      margin-top: 7px;
      color: black;
      font-size: 20px;
      a{
        color:#9932CC;
        font-size: 20px;
      }
    }
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
    &:active{
      transform: scale(.9);
    }

    &:focus{
      outline: none;
    }
  }

  a{
    color:#222;
    text-decoration: none;
    margin:15px 0;
    font-size: 1rem;
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
    padding: 120px 60px;
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
      margin: 1px;
      width: 330px;
      

    }

    button.google{
      border-color: black;
      margin: 10px;
      width: 330px;
    }
    
  }
</style>
