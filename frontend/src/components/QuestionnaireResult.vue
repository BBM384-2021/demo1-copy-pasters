<template>
    <div>
        <div class="container">
            <a class="logo" href="#">Social Interest e-Club</a>
            <div class="start">Start</div>
            <div class="progress-bar-front bar"></div>
            <div class="progress-bar-back"></div>
            <div class="finish">Finish</div>
        </div>

    <form class="questionnaire-result" action="#">
        <h1 class="h1">Here are your result!</h1>
        <div class="grid-container">
            <h2 class="sub-club"> Sub-Club</h2>
            <h2 class="score"> Score</h2>
            <h2 class="join-que"> Want to Join?</h2>
            <div class="sub-club-section " v-for="(subclub,index) in subclubs" :key="index">
                    <div class="responsive">
                        <div class="gallery">
                            <img class="image" :src="require('@/assets/sub-clubs-images/' + subclub.subclubName + '.jpg')">
                            <div class="desc">{{subclub.subclubName}}</div>
                        </div>
                        </div>

                    
                    <h3 v-if="subclub.score>50" class="score-result" style="color:#0cf12a ">{{subclub.score}}%</h3>
                    <h3 v-else class="score-result" style="color:red ">{{subclub.score}}%</h3>
                    <div v-if="subclub.score>50">
                        <input class="join-btn option-input checkbox" type="checkbox" v-model="subclubName" :value="index" >
                    </div>
                     
            </div>

        <button @click=" goToHomePage()" class="button "><span> JOIN </span></button>

        </div>
    </form>

    </div>
  
</template>

<script>
export default {
    name:"result",
    data(){
      
        return{
            subclubs:[
                { 
                id:1,
	    		      subclubName:"Yoga",
	    		      score:70,
              
	    		
	    	},
	    	{  
                id:3,
	    		      subclubName:"Novel",
	    		      score:60,
               
	    	},
            	{  
                id:4,
	    		      subclubName:"Piano",
	    		      score:40,
                
	    	},
            
            ]
        }
    },
    methods:{
            goToHomePage(){
                this.$router.push("/");
            }
    }
}
</script>
<style scoped lang="scss">
    @import '../assets/css/que-header.css';
    .bar{
      width: 90%;
    }
    @import '../assets/css/que-result.css';

</style>
