import { Box, createTheme, CssBaseline, ThemeProvider } from "@mui/material";
import React from "react";
import AppBar from "../Components/SideBar/AppBar";
import MenuHeader from "../Components/SideBar/MenuHeader";
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
  const themeDark = createTheme({
    palette: {
      background: {
        default: "#062740",
      },
      text: {
        primary: "rgb(231, 235, 240)",
      },
    },
  });
  return (
    <ThemeProvider theme={themeDark}>
      <Box sx={{ display: "flex" }}>
        <CssBaseline />
        <AppBar open={open} handleDrawerOpen={handleDrawerOpen} />
        <SideBar open={open} handleDrawerClose={handleDrawerClose} />
        <Box component="main" sx={{ flexGrow: 1, p: 3 }}>
          <MenuHeader handleDrawerClose={handleDrawerClose} />
          <Content />
        </Box>
      </Box>
    </ThemeProvider>
  );
}

export default Layout;
