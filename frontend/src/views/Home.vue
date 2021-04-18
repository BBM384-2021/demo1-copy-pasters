<template>
 <article>
   <head>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge" />

   </head>
   <body>
    <main>
      <div class="header">
        <div class="logo">
          <a href="#" class="logo">Logo</a>
        </div>
        <ul>
          <li><a href="#" class="SignUp">Sign Up</a></li>
          <li><a href="#" class="LogIn" @click="goToSignIn()">Log In</a></li>
          <li><a href="#" class="About">About</a></li>
        </ul>
      </div>
      <div class="center">
        <h1>Union Of Interest</h1>
        <h2>The best platform to find people<br>with the same interests as you.<br></h2>
      </div>
      
    </main>
   </body>
  </article>
</template>

<script>
// @ is an alias to /src


export default {
  name: "Home",
  methods: {
    goToSignIn(){
      this.$router.push({path: "/SignIn"});
    }
  },
  components: {
    
  },
};
</script>

<style scoped lang="scss">
@import url('https://fonts.googleapis.com/css2?family=Alegreya+Sans:wght@800&display=swap');
  *{
    margin: 0;
    padding: 0;
    box-sizing: border-box;
  }
  body,html{
    background-image: url("~@/assets/background.jpeg");
    height: 100%;
    background-size: 100% 100%;
}
  .header{
    height: 30%;
    grid-area:header;
    background: rgba($color: white, $alpha: 0.5);
    border-bottom: 0.2em solid palevioletred;
  }
  .logo{
    margin-left: 1%;
    margin-top: 1%;
    margin-left: 1%;
  }
  .logo a{
    text-decoration: none;
    color:black;
    font-family: Alegreya Sans;
    font-size: 130%;
   
  }

  .center{
    background: rgba($color: #ffffff, $alpha: 0.5);
    border-radius: 5em;
    border:0.2em solid black;
    text-align: center;
    font-family: Alegreya Sans;
    h1{
      font-size: 300%;
      margin-top:1em;
    }
    h2{
      margin-top:0.5em;
      margin-bottom: 1em;
      font-size: 200%;
    }
  }
  .header ul{
 /*  float: right;
    margin-right: 2%;
    margin-top: 0.5%;*/
  }
  .header ul li{
    list-style: none;
    float: right;
    display: inline-block;
    margin-right:1em;
    margin-top:-1.5em;
    
  }
  .header ul li a{
    color:rgb(95, 3, 138);
    text-decoration: none;
    font-family: Alegreya Sans;
    font-size: 130%;
    
  }
  .header ul li .About{
    color:rgb(51, 50, 51);
  }
  .header ul li .LogIn {
    background: white;
    border-radius: 1em;
    padding:0.2em 1em 0.2em 1em;
  }
  .header ul li .SignUp {
    background: white;
    border-radius: 1em;
    padding:0.2em 1em 0.2em 1em;
  }
  .header ul li .SignUp:hover{
    background: plum;
    border-radius: 1em;
    
  }
  .header ul li .LogIn:hover{
    background: plum;
    border-radius: 1em;
    
  }

  .header ul li .About:hover{
    text-decoration-line: underline;
  }

  main{
    height: 100vh;
    display: grid;
    grid-template-columns: 1fr 3rf 1fr;
    grid-template-rows:1fr 1fr 1fr ;
    grid-template-areas:"header header header"
    ". center ." ;
  }

  .center{
    grid-area:center;
    
  }
  @media screen and (max-width:800px){
    .center {
      h1{
        font-size: 250%;
      }
      h2{
        font-size: 150%;
      }
    }
  }

</style>