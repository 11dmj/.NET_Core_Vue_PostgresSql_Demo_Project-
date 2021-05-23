<template>
    <div class="card mb-3 mt-5" style="max-width: 861px;">
        <div class="row no-gutters">
            <div class="col-md-6">
                <img src="../assets/Images/logo.png" class="card-img" alt="Login Image">
            </div>
            <div class="col-md-6">
                <div class="card-body">
                    <h3 class="card-title">Register</h3>
                    <LoginForm></LoginForm>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
    import LoginForm from '../components/loginform.vue'

    export default {
        name: 'login',
        components: {
            LoginForm
        },
        
    }
</script>