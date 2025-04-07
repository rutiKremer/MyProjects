import {NavLink} from "react-router";
import './App.css';

function App() {

  return (  
    
     <nav>
     <NavLink to="/UsersMenu" className={"menu"}>users entry</NavLink>
     <NavLink to="/ProducerMenu" className={"menu"}>producers entry</NavLink>
      </nav>   
  )
}
export default App
