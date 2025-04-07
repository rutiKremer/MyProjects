import { useParams } from "react-router";

export const EventDetailsForUser = () => {
   
   const {_id,name,description,producerId} = useParams();
   
   return(
       <div>
         <h2>{_id}</h2>
         <h2>{name}</h2>
         <h2>{description}</h2>
         <h2>{producerId}</h2>
         <button>edit</button>
       </div>
    )
   }
   
