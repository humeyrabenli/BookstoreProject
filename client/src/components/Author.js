import {
  ListGroup,
  ListGroupItem,
  ListGroupItemHeading,
  
} from "reactstrap";

const Author = (props) => {
  const { authorId, authorName, authorLastName } = props.author;

  return (
    <div>
      <ListGroup>
        <ListGroupItem>
          <ListGroupItemHeading>
            {authorName} {authorLastName}
          </ListGroupItemHeading>
        </ListGroupItem>
      </ListGroup>
    </div>
  );
};

export default Author;
