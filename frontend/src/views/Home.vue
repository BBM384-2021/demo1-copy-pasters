<template>
  <div class="home">
    <img alt="Vue logo" src="../assets/logo.png" />
    <HelloWorld msg="Welcome to Your Vue.js App" />
    <button class="login" @click="goToSignIn()">Log In</button>
  </div>
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
