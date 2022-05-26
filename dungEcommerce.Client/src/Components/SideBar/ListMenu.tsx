import {
  Divider,
  List,
  ListItem,
  ListItemButton,
  ListItemIcon,
  ListItemText,
} from "@mui/material";
import { InfoOutlined,Home } from "@mui/icons-material";
import { Link } from "react-router-dom";
import './ListMenu.scss';
interface Props {
  open: boolean;
}

let listData =[
{name:'Home',icon:<Home/>,link:'/'},
{name:'About',icon: <InfoOutlined/>,link:'/about'}
]

function ListMenu({ open }: Props) {
  return (
    <div>
      <Divider />
      <List>
        {listData.map((item, index) => (
          <ListItem key={index} disablePadding sx={{ display: "block" }}>
            <Link to={item.link} id='linkRoute'>
            <ListItemButton
              sx={{
                minHeight: 48,
                justifyContent: open ? "initial" : "center",
                px: 2.5,
              }}
            >
              <ListItemIcon
                sx={{
                  minWidth: 0,
                  mr: open ? 3 : "auto",
                  justifyContent: "center",
                }}
              >{item.icon}
              </ListItemIcon>
              <ListItemText primary={item.name} sx={{ opacity: open ? 1 : 0 }} />
            </ListItemButton>
            </Link>
          </ListItem>
        ))}
      </List>
    </div>
  );
}

export default ListMenu;
