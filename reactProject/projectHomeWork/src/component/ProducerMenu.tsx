import { useState } from "react";
import { AddProducer } from "./AddProducer";
import { ProducerDetails } from "./ProducerDetails";
import '../index.css';
export const ProducerMenu = () => {

    const [isAddProducerVisible, setAddProducerVisible] = useState(false);
    const [isexistProducerVisible, setexistProducerVisible] = useState(false);
    const [emailP, setEmailP] = useState("");

    const handleAddProducer = () => {
        setAddProducerVisible(true);
        console.log("Add function defined");
    };

    const handlexistProducer = (event: any) => {
        event.preventDefault();
        setEmailP(event.target.email.value);
        setexistProducerVisible(true);
    };

    return (
        <>
            <div className="producer-container">
                <button onClick={handleAddProducer} className="producer">add producer</button>
                <form onSubmit={handlexistProducer}>
                    <input type="text" placeholder="producer mail" name="email" className="producer" />
                    <button type="submit" className="producer">exist producer</button>
                </form>
            </div>
            {isAddProducerVisible && <AddProducer />}
            {isexistProducerVisible && <ProducerDetails email={emailP} />}
        </>
    );
};