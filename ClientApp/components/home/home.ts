import Vue from 'vue';
import { Component } from 'vue-property-decorator';


@Component({
    components: {
        QuestionAndOptionsComponent : require('../home/questionandoptions/questionandoptions.vue.html')
    }
})
export default class HomeComponent extends Vue {


}
