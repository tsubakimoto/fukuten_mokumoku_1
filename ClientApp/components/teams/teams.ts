import Vue from 'vue';
import { Component } from 'vue-property-decorator';

interface Team {
    key: string;
    name: string;
    city: string;
    league: string;
    division: string;
}

@Component
export default class TeamComponent extends Vue {
    teams: Team[] = [];

    mounted() {
        fetch('api/Mlb/Team')
            .then(response => response.json() as Promise<Team[]>)
            .then(data => {
                this.teams = data;
            });
    }
}
