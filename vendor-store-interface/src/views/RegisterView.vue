<template>
  <section id="page">
    <nav-bar> </nav-bar>
    <section style="padding: 80px 0px">
      <main class="site-body">
        <div class="box-register">
          <div
            class="box-header"
            style="
              background-image: url('https://swensens1112.com/images/card-head.png');
            "
          >
            <h2>Register</h2>
            <p>Register to start you sweet journey</p>
          </div>
          <div class="box-body">
            <form method="post">
              <div class="step1" v-show="currentStep === 1">
                <div class="row">
                  <label class="col"> First Name </label>
                  <label class="col"> Last Name </label>
                </div>
                <div class="row" style="margin-bottom: 24px">
                  <div class="col">
                    <input type="text" v-model="formInput.firstName" placeholder="First Name" />
                  </div>
                  <div class="col">
                    <input type="text" v-model="formInput.lastName"  placeholder="Last Name" />
                  </div>
                </div>
                <div style="margin-bottom: 24px">
                  <label>Mobile Number</label>
                  <input type="text" placeholder="10-digit mobile number" />
                </div>
                <div style="margin-bottom: 24px">
                  <label>Email</label>
                  <input type="email" placeholder="Email" />
                </div>
                <div style="margin-bottom: 24px">
                  <label>Password</label>
                  <input type="password" placeholder="Password" />
                </div>
                <div style="margin-bottom: 24px">
                  <label>Gender(optional)</label>
                  <div class="d-flex flex-nowrap flex-grow-1">
                    <button
                      @click="onClickGender('Male')"
                      :class="{
                        'gender-btn-radio-active': genderMale,
                      }"
                      class="gender-btn-radio"
                      type="button"
                    >
                      <span>Male</span>
                    </button>
                    <button
                      @click="onClickGender('Female')"
                      :class="{
                        'gender-btn-radio-active': genderFemale,
                      }"
                      class="gender-btn-radio"
                      type="button"
                    >
                      Female
                    </button>
                    <button
                      type="button"
                      @click="onClickGender('Not Specified')"
                      :class="{
                        'gender-btn-radio-active': genderNone,
                      }"
                      class="gender-btn-radio"
                      style="white-space: nowrap"
                    >
                      <span>Not Specified</span>
                    </button>
                  </div>
                </div>
                <div style="margin-bottom: 24px">
                  <label>Birthday</label>
                  <div>
                    <a-date-picker></a-date-picker>
                  </div>
                </div>
                <div class="d-flex justify-content-end">
                  <button
                    @click="clickNextStep()"
                    type="button"
                    class="register-btn register-btn-primary"
                  >
                    Next
                  </button>
                </div>
              </div>
              <div class="step2" v-show="currentStep === 2">
                <div style="margin-bottom: 24px">
                  <label>Address</label>
                  <input type="text" placeholder="Address" />
                </div>
                <div style="margin-bottom: 24px">
                  <label>Postal Code</label>
                  <input type="text" placeholder="Postal Code" />
                </div>
                <div style="margin-bottom: 24px">
                  <label>City</label>
                  <input type="text" placeholder="City" />
                </div>
                <div style="margin-bottom: 24px">
                  <label>Country</label>
                  <input type="text" placeholder="Country" />
                </div>
                <div class="d-flex justify-content-end">
                  <button
                    @click="goBackOneStep()"
                    type="button"
                    class="register-btn me-3"
                  >
                    Back
                  </button>
                  <button
                    @click="clickNextStep()"
                    type="button"
                    class="register-btn register-btn-primary"
                  >
                    Next
                  </button>
                </div>
              </div>
              <div class="step3" v-show="currentStep === 3">
                <div class="row">
                  <label class="col"> First Name </label>
                  <label class="col"> Last Name </label>
                </div>
                <div class="row" style="margin-bottom: 24px">
                  <div class="col">
                    <input
                      type="text"
                      placeholder="First Name"
                      v-model="form.Input.firstName"
                      readonly
                      style="cursor: initial"
                    />
                  </div>
                  <div class="col">
                    <input
                      type="text"
                      placeholder="Last Name"
                       v-model="form.Input.Lastname"
                      readonly
                      style="cursor: initial"
                    />
                  </div>
                </div>
                <div style="margin-bottom: 24px">
                  <label>Mobile Number</label>
                  <input
                    type="text"
                    placeholder="10-digit mobile number"
                    readonly
                    style="cursor: initial"
                  />
                </div>
                <div style="margin-bottom: 24px">
                  <label>Email</label>
                  <input
                    type="email"
                    placeholder="Email"
                    readonly
                    style="cursor: initial"
                  />
                </div>
                <div style="margin-bottom: 24px">
                  <label>Password</label>
                  <input
                    type="text"
                    placeholder="Password"
                    readonly
                    style="cursor: initial"
                  />
                </div>
                <div style="margin-bottom: 24px">
                  <label>Gender(optional)</label>
                  <div class="d-flex flex-nowrap flex-grow-1">
                    <button
                      class="gender-btn-radio"
                      :class="{
                        'gender-btn-radio-active': genderMale,
                      }"
                      type="button"
                      style="cursor: initial"
                    >
                      <span>Male</span>
                    </button>
                    <button
                      class="gender-btn-radio"
                      type="button"
                      style="cursor: initial"
                      :class="{
                        'gender-btn-radio-active': genderFemale,
                      }"
                    >
                      Female
                    </button>
                    <button
                      type="button"
                      class="gender-btn-radio"
                      style="white-space: nowrap; cursor: initial"
                      :class="{
                        'gender-btn-radio-active': genderNone,
                      }"
                    >
                      <span>Not Specified</span>
                    </button>
                  </div>
                </div>
                <div style="margin-bottom: 24px">
                  <label>Address</label>
                  <input type="text" placeholder="Postal Code" readonly />
                </div>
                <div style="margin-bottom: 24px">
                  <label>Postal Code</label>
                  <input type="text" placeholder="Postal Code" readonly />
                </div>
                <div style="margin-bottom: 24px">
                  <label>City</label>
                  <input type="text" placeholder="Postal Code" readonly />
                </div>
                <div style="margin-bottom: 24px">
                  <label>Country</label>
                  <input type="text" placeholder="Postal Code" readonly />
                </div>
                <div class="d-flex justify-content-end">
                  <button
                    @click="goBackOneStep()"
                    type="button"
                    class="register-btn me-3"
                  >
                    Back
                  </button>
                  <button
                    @click="submit()"
                    type="button"
                    class="register-btn register-btn-primary"
                  >
                    Submit
                  </button>
                </div>
              </div>
            </form>
          </div>
        </div>
      </main>
    </section>
    <foot-bar></foot-bar>
  </section>
</template>

<script>
import { watch } from "@vue/runtime-core";
import { DateTime } from "luxon";
import FootBar from "../components/FootBar.vue";
import NavBar from "../components/NavBar.vue";
export default {
  components: {
    FootBar,
    NavBar,
  },
  data() {
    return {
      currentStep: 1,
      genderMale: false,
      genderFemale: false,
      genderNone: true,
      onSelectGender: "Not Specified",
      formInput: {
        firstName:"",
        lastName:"",
        phone: "",
        email:"",
        password:"",
        gender: "Not Specified",
        birthDay:"",
        address:"",
        postalCode:"",
        city:"",
        country:""
      },
    };
  },
  watch: {
    onSelectGender() {
      if (this.onSelectGender === "Male") {
        this.genderMale = true;
        this.genderFemale = false;
        this.genderNone = false;
      }
      if (this.onSelectGender === "Female") {
        this.genderMale = false;
        this.genderFemale = true;
        this.genderNone = false;
      }
      if (this.onSelectGender === "Not Specified") {
        this.genderMale = false;
        this.genderFemale = false;
        this.genderNone = true;
      }
    },
  },
  methods: {
    onClickGender(gender) {
      this.onSelectGender = gender;
      this.formInput.gender = this.onSelectGender;
    },
    clickNextStep() {
      this.currentStep++;
    },
    goBackOneStep() {
      this.currentStep--;
    },
    async submit(){

    }
  },
};
</script>

<style FootBarNavBarscoped>
#page {
  min-height: 100vh;
  background-color: #f4f4f4;
}
.box-register {
  max-width: 480px;
  margin: 0 auto;
  overflow: hidden;
  border-radius: 10px;
  background-color: #fff;
}
.box-register .box-header {
  color: #fff;
  height: 240px;
  padding: 32px 40px;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: flex-start;
  background-color: #dbdbdb;
  background-size: cover;
  background-position: top;
}
.box-register .box-body {
  padding: 40px;
}

.ant-picker {
  box-sizing: border-box;
  margin: 0;
  padding: 0;
  color: rgba(0, 0, 0, 0.85);
  font-size: 14px;
  font-variant: tabular-nums;
  line-height: 1.5715;
  list-style: none;
  font-feature-settings: "tnum";
  padding: 4px 11px 4px;
  position: relative;
  display: inline-flex;
  align-items: center;
  background: #fff;
  border: 1px solid #d2d2d2;
  border-radius: 10px !important;
  transition: border 0.3s, box-shadow 0.3s;
  width: 100%;
  height: 48px;
  outline: none !important;
}
.ant-picker:hover,
.ant-picker-focused {
  border-color: #d2d2d2 !important;
  outline: none !important;
  border-right-width: 1px !important;
}
/* radio */
.gender-btn-radio {
  line-height: 1.25;
  height: auto;
  max-height: 43.5px;
  margin: 0 8px;
  padding: 12px 32px;
  border-radius: 30px;
  border: 1px solid #d2d2d2;
  outline: none;
  font-weight: 300;
  color: #e21c23;
  background: #fff;
  transition: color 0.3s, background 0.3s, border-color 0.3s;
}
.gender-btn-radio-active {
  color: #fff;
  background: #e21c23;
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

/* label */
label {
  position: relative;
  display: inline-block;
  overflow: hidden;
  /* line-height: 47.9999px; */
  white-space: nowrap;
  vertical-align: middle;
  color: #3b3b3b;
  margin-bottom: 8px;
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
/* button */
.register-btn {
  min-width: 140px;
  line-height: 46px;
  padding-top: 0.1px;
  padding: 0 15px;
  border-radius: 50px;
  position: relative;
  font-weight: 300;
  white-space: nowrap;
  text-align: center;
  background-image: none;
  background-color: #fff;
  box-shadow: 0 2px 0 rgb(0 0 0 / 2%);
  color: #e21c23;
  font-size: 14px;
  border: 1px solid #e21c23;
}

.register-btn-primary {
  color: #ffff;
  background-color: #e21c23;
  text-shadow: 0 -1px 0 rgb(0 0 0 / 12%);
}

input[type="password"]::-ms-reveal,
input[type="password"]::-ms-clear {
  display: none;
}
</style>
