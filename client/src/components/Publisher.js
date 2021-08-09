import { ListGroup, ListGroupItem, ListGroupItemHeading } from 'reactstrap';


const Publisher = (props) => {
  const { publisherId, publisherName } = props.publisher;
  
  
 

  return (
    <div>
      <ListGroup>
        <ListGroupItem>
        <ListGroupItemHeading>{publisherName}</ListGroupItemHeading>
        </ListGroupItem>
      </ListGroup>
      
    </div>
  );
};

export default Publisher;