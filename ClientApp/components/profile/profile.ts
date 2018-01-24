import Vue from 'vue';
import { Component } from 'vue-property-decorator';

interface Profile {
    name: string;
    age: number;
}

@Component
export default class ProfileComponent extends Vue {
    profile: Profile[] = [];

    mounted() {
        fetch('Home/Profile')
            .then(response => response.json() as Promise<Profile[]>)
            .then(data => {
                this.profile = data;
            });
    }
}
