<template>
    <div class="d-flex flex-column flex-shrink-0 p-3" style="width:auto;background-color:rgb(38 37 40)">
        <!--<a href="/" class="d-flex align-items-center mb-3 mb-md-0 me-md-auto link-dark text-decoration-none">
            <svg class="bi me-2" width="40" height="32"><use xlink:href="#bootstrap"></use></svg>
            <span class="fs-4">Sidebar</span>
        </a>
        <hr>-->
        <ul class="nav nav-pills flex-row mb-auto">
            <li class="nav-item">
                <a href="#" class="nav-link active" aria-current="page">
                    <svg class="bi me-2" width="16" height="16"><use xlink:href="#home"></use></svg>
                    Dashboard
                </a>
            </li>
            <li>
                <a href="#" class="nav-link link-light">
                    <svg class="bi me-2" width="16" height="16"><use xlink:href="#speedometer2"></use></svg>
                    Employees
                </a>
            </li>
            <li>
                <a href="#" class="nav-link link-light">
                    <svg class="bi me-2" width="16" height="16"><use xlink:href="#table"></use></svg>
                    Leave
                </a>
            </li>
            <li>
                <div class="dropdown">
                    <a href="#" class="d-flex align-items-center link-light text-decoration-none dropdown-toggle show" id="dropdownUser2" data-bs-toggle="dropdown" aria-expanded="true">

                        Settings
                    </a>
                    <ul class="dropdown-menu text-small shadow" aria-labelledby="dropdownUser2" data-popper-placement="top-start" style="position: absolute; inset: auto auto 0px 0px; margin: 0px; transform: translate(0px, -34px);">
                        <li>
                            <a class="dropdown-item" href="#">
                                <img src="https://github.com/mdo.png" alt="" width="32" height="32" class="rounded-circle me-2">
                                Profile
                            </a>
                        </li>
                        <li><hr class="dropdown-divider"></li>
                        <li><a class="dropdown-item" href="#">Sign out</a></li>
                    </ul>
                </div>
                <!--<a href="#" class="nav-link link-light">
                    <svg class="bi me-2" width="16" height="16"><use xlink:href="#grid"></use></svg>
                    WorkFromHome
                </a>-->
            </li>
            <li>
                <div class="dropdown">
                    <a href="#" class="d-flex align-items-center link-light text-decoration-none dropdown-toggle show" id="dropdownUser2" data-bs-toggle="dropdown" aria-expanded="true">
                        
                        Settings
                    </a>
                    <ul class="dropdown-menu text-small shadow" aria-labelledby="dropdownUser2" data-popper-placement="top-start" style="position: absolute; inset: auto auto 0px 0px; margin: 0px; transform: translate(0px, -34px);">
                        <li><a class="dropdown-item" href="#">
                            <img src="https://github.com/mdo.png" alt="" width="32" height="32" class="rounded-circle me-2">
                            Profile</a></li>
                        <li><hr class="dropdown-divider"></li>
                        <li><a class="dropdown-item" href="#">Sign out</a></li>
                    </ul>
                </div>
            </li>
        </ul>
        
    </div>
</template>

<script>
    export default {
        name: 'sidebar',
        components: {},
        data() {}
    }
</script>