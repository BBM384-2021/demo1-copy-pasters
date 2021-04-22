<template>
    <div class="header">
        <div class="container">
            <a class="logo" href="#">Social Interest e-Club</a>
            <div class="start">Start</div>
            <div class="progress-bar-front bar"></div>
            <div class="progress-bar-back"></div>
            <div class="finish">Finish</div>
        </div>
        <h1 class="h1">Questionnaire</h1>
        <form class="questionnaire" action="#">
            <div class="space" v-for="j in questions" :key="j">
                <div class="question text "> {{j.questionText}}</div>
                    <div class="options-container">
                      <div class="option" v-for="(i,index) in j.choises" :key="index">
                            <input class="option-input radio" type="radio" :value="index" v-model="j.id">
                            <label class="label" :for="i">
                                <span class="text">{{i}}</span>
                            </label>
                        </div>       
                    </div>
            </div>
            <button @click=" goToQuestionnaireResultPage()" class="button"><span> SUBMIT </span></button>
        </form>
    </div>
</template>

<script>
    export default {
        name:"quiz",
        data() { return{
            questions:[
	    	{ 
                id:1,
	    		subclubName:"Yoga",
	    		questionText: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Omnis, hic?", 
	    		choises: ["0-200","200-400","400-600","600+"]
	    		
	    	},
	    	{  
                id:2,
	    		subclubName:"Art",
	    		questionText: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Omnis, hic?", 
	    		choises: ["0-200","200-400","400-600","600+"]
	    	}
	          ]
        }
    },
       methods:{
            goToQuestionnaireResultPage(){
                this.$router.push("/questionnaire-result-page");
            }

    }
    
    }

    
</script>

<style scoped lang="scss">
    @import '../assets/css/que-header.css';
    @import '../assets/css/que-body.css';
    .bar{
      width: 60%;
    }
</style>