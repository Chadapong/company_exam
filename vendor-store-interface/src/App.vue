<script setup>
import { RouterView } from "vue-router";
</script>

<template>
  <RouterView />
</template>

<style>
@import url('https://fonts.googleapis.com/css2?family=Kanit:wght@300;400;500&display=swap');
/* body */
h2{
  color: white !important;;
}

body,
input {
  font-weight: 300;
}
body {
  margin: 0;
  color: #787878;
  font-size: 14px;
  font-family: "Kanit", sans-serif;
  font-variant: tabular-nums;
  line-height: 1.5;
  background-color: #f4f4f4;
  font-feature-settings: "tnum", "tnum";
}
body,
html {
  width: 100%;
  height: 100%;
}
/* site header */
.site-header {
  z-index: 5000;
}
/* site css */
.site-body {

  margin-top: 72px;
}

/* svg */
svg:not(:root) {
  overflow: hidden;
}
/* any swensens logo */
.swensens-logo {
  -webkit-animation: appear 1s;
  animation: appear 1s;
  margin: auto;
}
</style>
