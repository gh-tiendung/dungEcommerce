import { IconButton, styled, useTheme } from "@mui/material";
import ChevronLeftIcon from "@mui/icons-material/ChevronLeft";
import ChevronRightIcon from "@mui/icons-material/ChevronRight";

interface Props {
  handleDrawerClose: any;
}

const DrawerHeader = styled("div")(({ theme }) => ({
  display: "flex",
  alignItems: "center",
  justifyContent: "flex-end",
  padding: theme.spacing(0, 1),
  minHeight: "64px",
  backgroundColor: '#062740'
}));

function MenuHeader({ handleDrawerClose }: Props) {
  const theme = useTheme();
  return (
    <DrawerHeader>
      <IconButton onClick={handleDrawerClose}>
        {theme.direction === "rtl" ? <ChevronRightIcon /> : <ChevronLeftIcon />}
      </IconButton>
    </DrawerHeader>
  );
}

export default MenuHeader;
