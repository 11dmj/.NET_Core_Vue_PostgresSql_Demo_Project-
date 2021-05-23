

<template>
    <div v-if="login">
        <NavBar></NavBar>
        <Home></Home>
    </div>
    <div v-if="!login" class="mt-20" style="display:flex;justify-content:center;align-items:center;">
        <Login></Login>
    </div>

    <!--<div class="row" style="display:inline-flex;justify-content:center;align-items:center;">
        <div class="col-md-6">
            <div>
                <img alt="Vue logo" src="./assets/Images/logo.png">
            </div>
            <HelloWorld msg="Welcome to SamrtPunch" />
            <Login></Login>
        </div>
        <div class="col-md-6" style="display:block">
            <h2>Register</h2>
            <form>

                <div class="form-group">
                    <label>First Name</label>
                    <input type="text" class="form-control" name="firstname" v-model="register.firstname" />
                </div>
                <div class="form-group">
                    <label>Middle Name</label>
                    <input type="text" class="form-control" name="middlename" v-model="register.middlename" />
                </div>
                <div class="form-group">
                    <label>Last Name</label>
                    <input type="text" class="form-control" name="lastname" v-model="register.lastname" />
                </div>
                <div class="form-group">
                    <label>Password</label>
                    <input type="text" class="form-control" name="psswd" v-model="register.psswd" />
                </div>

                <button v-on:click="onRegister">Register</button>
            </form>
        </div>

    </div>-->

</template>

<script>
    //import HelloWorld from './components/HelloWorld.vue'
    import Login from './components/login.vue'
    import NavBar from './components/navbar.vue'
    import Home from './components/home.vue'
    
    
    //import axios from 'axios'
    //import query from 'query-string'

    export default {
        name: 'App',
        components: {
            //HelloWorld,
            Login,
            NavBar,
            Home,     
        },
        data() {
            return {
                //show: false,
                //login: true
                show: true,
                login: false
            }
        }
        //data() {
        //    return {
        //        register: {
        //            //empId: "",
        //            firstname: "",
        //            middlename: "",
        //            lastname: "",
        //            psswd: ""
        //        }
        //    };
        //},
        //methods: {
        //    onRegister: function () {

        //        const _self = this;
        //        let config = {
        //            headers: { 'Content-Type': 'application/json' }
        //        };
        //        //this.register.firstname = _self.firstname;
        //        //this.register.middlename = _self.middlename;
        //        //this.register.lastname = _self.lastname;
        //        //this.register.psswd = _self.psswd;

        //        //var i = query.stringify(_self.register);
        //        const _api = axios.post('https://localhost:44367/api/employees', _self.register, config);
        //        _api.then(response => {
        //            console.log(response.data);

        //            alert(response.data);
        //        })
        //            .catch(err => {
        //                alert(err + " Cannot Register!");
        //            });

        //    }
        //}
    }
</script>

<style>
    #app {
        font-family: Avenir, Helvetica, Arial, sans-serif;
        -webkit-font-smoothing: antialiased;
        -moz-osx-font-smoothing: grayscale;
        text-align: center;
        color: #2c3e50;
        margin-top: 60px;

    }
</style>
