import Vue from 'vue';
import { Component } from 'vue-property-decorator';

interface Question {
    id: number;
    questionBody: string;
    answerOption1: string;
    answerOption2: string;
    answerOption3: string;
    answerOption4: string;
    answerId : number;
}

@Component
export default class HomeComponent extends Vue {
    questions: Question[] = [];

    mounted() {
        fetch('api/SampleData/Questions')
            .then(response => response.json() as Promise<Question[]>)
            .then(data => {
                this.questions = data;
            });
    }
}
