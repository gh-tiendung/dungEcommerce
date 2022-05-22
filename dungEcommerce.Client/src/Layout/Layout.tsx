import { Box, CssBaseline, styled, useTheme } from "@mui/material";
import Tracker from "@openreplay/tracker";
import React from "react";
import AppBar from "../Components/SideBar/AppBar";
import SideBar from "../Components/SideBar/SideBar";
import Content from "./Content";

// const tracker = new Tracker({
//   projectKey: "53T7cIFHUg8VwKFG5vn0",
// });


function Layout() {
  //tracker.start();
  const [open, setOpen] = React.useState(false);

  const handleDrawerClose = () => {
    setOpen(false);
  };
  const handleDrawerOpen = () => {
    setOpen(true);
  };


  return (
    <div>
      <Box sx={{ display: "flex" }}>
        <CssBaseline />
        <AppBar open={open} handleDrawerOpen={handleDrawerOpen}/>
        <SideBar open={open} handleDrawerClose={handleDrawerClose}/>
        <Box component="main" sx={{ flexGrow: 1, p: 3 }}>
          {/* <DrawerHeader /> */}
          {/* <SideBar/> */}
          <Content />
        </Box>
      </Box>
    </div>
  );
}

export default Layout;
