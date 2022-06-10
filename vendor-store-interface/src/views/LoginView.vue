<template>
  <section id="page">
    <nav-bar> </nav-bar>
    <section style="padding: 80px 0px">
      <main class="site-body" >
        <div class="box-login">
          <div
            class="box-header"
            style="
              background-image: url('https://swensens1112.com/images/card-head.png');
            "
          >
            <h2>Welcome</h2>
            <p>Login to begin journey</p>
          </div>
          <div class="box-body">
            <form method="post">
              <div class="form-item">
                <label title="Email">Email</label>
                <input placeholder="Email" type="email" />
              </div>
              <div class="form-item">
                <label title="Email">Password</label>
                <input placeholder="Password" type="password" />
                <!-- <span class="password-icon"><eye-outlined /></span> -->
              </div>
              <div class="form-item d-flex justify-content-end">
                <a class="forget-password" style="margin-bottom: 24px"
                  >Forgot password?</a
                >
              </div>
              <button class="login-btn-primary" style="width: 100%">
                Login
              </button>
            </form>
          </div>
        </div>
      </main>
    </section>
    <foot-bar></foot-bar>
  </section>
</template>

<script>
import FootBar from "../components/FootBar.vue";
import NavBar from "../components/NavBar.vue";
import { EyeOutlined, EyeInvisibleOutlined } from "@ant-design/icons-vue";
export default {
  components: { NavBar, FootBar, EyeOutlined, EyeInvisibleOutlined },
};
</script>

<style scoped>
#page {
  min-height: 100vh;
  background-color: #f4f4f4;
}
.box-login {
  max-width: 480px;
  margin: 0 auto;
  overflow: hidden;
  border-radius: 10px;
  background-color: #fff;
}
.box-login .box-header {
  color: #fff;
  height: 240px;
  padding: 40px;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: flex-start;
  background-color: #dbdbdb;
  background-size: cover;
  background-position: top;
}
.box-login .box-body {
  padding: 40px;
}
/* button */
button {
  line-height: 1.499;
  position: relative;
  display: inline-block;
  font-weight: 300;
  white-space: nowrap;
  text-align: center;
  background-image: none;
  box-shadow: 0 2px 0 rgb(0 0 0 / 2%);
  cursor: pointer;
  transition: all 0.3s cubic-bezier(0.645, 0.045, 0.355, 1);
  -webkit-user-select: none;
  -moz-user-select: none;
  -ms-user-select: none;
  user-select: none;
  touch-action: manipulation;
  height: 48px;
  padding: 0 15px;
  font-size: 14px;
  border-radius: 50px;
  color: #e21c23;
  background-color: #fff;
  border: 1px solid #e21c23;
}
.login-btn-primary {
  color: #fff;
  background-color: #e21c23;
  border-color: #e21c23;
  text-shadow: 0 -1px 0 rgb(0 0 0 / 12%);
  box-shadow: 0 2px 0 rgb(0 0 0 / 5%);
}
.login-btn-primary:hover {
  color: #fff;
  background-color: #e21c23;
  border-color: #e21c23;
  opacity: 0.85;
  transition: opacity 0.2s;
}
.login-btn-primary:active {
  background-color: #bd0d19;
  border-color: #bd0d19;
  opacity: 1;
  transition: opacity 0.2s;
}
/* a */

a {
  color: #e21c23;
  text-decoration: none;
  background-color: transparent;
  outline: none;
  cursor: pointer;
  transition: color 0.3s;
}

a:active,
a:hover {
  text-decoration: none;
  outline: 0;
}
a:hover {
  color: #f04343;
}
a:active,
a:hover {
  text-decoration: none;
  outline: 0;
}
a:active {
  color: #bd0d19;
}

/* form */
form {
  box-sizing: border-box;
  margin: 0;
  padding: 0;
  color: #787878;
  font-size: 14px;
  font-variant: tabular-nums;
  line-height: 1.5;
  list-style: none;
  font-feature-settings: "tnum", "tnum";
}
label {
  position: relative;
  display: inline-block;
  overflow: hidden;
  /* line-height: 47.9999px; */
  white-space: nowrap;
  text-align: right;
  vertical-align: middle;
  color: #3b3b3b;
}

.form-item {
  box-sizing: border-box;
  padding: 0;
  color: #787878;
  font-size: 14px;
  font-variant: tabular-nums;
  line-height: 1.5;
  list-style: none;
  font-feature-settings: "tnum", "tnum";
  margin: 0 0 16px;
  vertical-align: top;
}

/* input */
input {
  outline: none;
  box-sizing: border-box;
  margin: 0;
  font-variant: tabular-nums;
  list-style: none;
  font-feature-settings: "tnum", "tnum";
  position: relative;
  display: inline-block;
  width: 100%;
  height: 48px;
  padding: 4px 11px;
  color: #787878;
  font-size: 14px;
  line-height: 1.5;
  background-color: #fff;
  background-image: none;
  border: 1px solid #d2d2d2;
  border-radius: 10px;
  transition: all 0.3s;
}
.input-wrapper {
  position: relative;
}
.input-wrapper:after {
  position: absolute;
  content: "";
  right: 12px;
}

input[type="password"]::-ms-reveal,
input[type="password"]::-ms-clear {
  display: none;
}
</style>
