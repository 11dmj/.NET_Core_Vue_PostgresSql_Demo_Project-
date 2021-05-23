<template>
    <div class="row">
        
        <div class="col-md-2" style="height:auto;background-color:rgb(38 37 40)">
            <SideBar></SideBar>
        </div>
        <div class="col-md-10" style="height:650px">
            <h4>Dashboard</h4>
            <table class="table table-striped">
                <thead>
                    <tr>
                        <th scope="col">#</th>
                        <th scope="col">First</th>
                        <th scope="col">Last</th>
                        <th scope="col">Handle</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <th scope="row">1</th>
                        <td>Mark</td>
                        <td>Otto</td>
                        <td>@mdo</td>
                    </tr>
                    <tr>
                        <th scope="row">2</th>
                        <td>Jacob</td>
                        <td>Thornton</td>
                        <td>@fat</td>
                    </tr>
                    <tr>
                        <th scope="row">3</th>
                        <td>Larry</td>
                        <td>the Bird</td>
                        <td>@twitter</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</template>

<script>
    import SideBar from '../components/sidebar.vue'
    export default {
        name: 'home',
        components: {
            SideBar
        }
    }
</script>