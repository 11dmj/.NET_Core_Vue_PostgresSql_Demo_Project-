<template>
    <div>
        <form class="row gy-3" @submit="onSubmit" @reset="onReset">
            <div class="form-group">
                <label for="firstname">First Name:</label>
                <input type="text" class="form-control" id="firstname" v-model="register.firstname" aria-describedby="emailHelp" placeholder="Enter firstname">
                <!--<small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>-->
            </div>
            <div class="form-group">
                <label for="middlename">Enter middlename:</label>
                <input type="text" class="form-control" id="middlename" v-model="register.middlename" placeholder="Enter middlename">
            </div>
            <div class="form-group">
                <label for="lastname">Last Name:</label>
                <input type="text" class="form-control" id="lastname" v-model="register.lastname" placeholder="Enter lastname">
            </div>
            <div class="form-group">
                <label for="middlename">Password:</label>
                <input type="password" class="form-control" id="psswd" v-model="register.psswd" placeholder="Enter password">
            </div>
            <button type="submit" class="btn btn-primary">Register</button>
        </form>
    </div>
   
</template>

<script>
    import axios from 'axios'
    //import query from 'query-string'

    export default {
        name: 'loginform',
        components: {},
        data() {
            return {
                register: {
                    firstname: '',
                    middlename: '',
                    lastname: '',
                    psswd: '',
                    //food: null,
                    //checked: []
                },
                //foods: [{ text: 'Select One', value: null }, 'Carrots', 'Beans', 'Tomatoes', 'Corn'],
                show: true
            }
        },
        methods: {
            onSubmit(event) {
                event.preventDefault()
                alert(JSON.stringify(this.register))
                const _self = this;
                let config = {
                    headers: { 'Content-Type': 'application/json' }
                };
                //this.register.firstname = _self.firstname;
                //this.register.middlename = _self.middlename;
                //this.register.lastname = _self.lastname;
                //this.register.psswd = _self.psswd;

                //var i = query.stringify(_self.register);
                const _api = axios.post('https://localhost:44367/api/employees', _self.register, config);
                _api.then(response => {
                    console.log(response.data);
                    alert(response.data);
                    
                })
                    .catch(err => {
                        alert(err + " Cannot Register!");
                    });
            },
            onReset(event) {
                event.preventDefault()
                // Reset our form values
                this.register.firstname = ''
                this.register.middlename = ''
                this.register.lastname = ''
                this.register.psswd = ''
                //this.form.food = null
                //this.form.checked = []
                // Trick to reset/clear native browser form validation state
                this.show = false
                this.$nextTick(() => {
                    this.show = true
                })
            }
        }
    }
</script>