import React, { useState } from "react";

import { useSelector } from "react-redux";
import { useNavigate } from "react-router-dom";
import { List, ListItem, Button, Box, Typography } from "@mui/material";

const style = {
  container: {
    //   width: "90%",
    margin: "10px auto",
    maxWidth: "700px",
  },
  list: {
    margin: "auto",
    width: "90%",
  },
  item: {
    border: "1px solid purple",
    borderRadius: "5px",
    margin: "5px 5px",
  },
  btn: {
    variant: "contained",
    border: "1px solid purple",

    maxWidth: "50%",
    textAlign: "center",
  },
};

const ListComponent = (props) => {
  const navigate = useNavigate();
  const recipes = useSelector((state) => state.states.recipes);
  const [loadCat, setLoadCat] = useState(2);

  return (
    <Box sx={style.container}>
      <List sx={style.list}>
        {!props.recipeView &&
          props.categories &&
          props.categories.slice(0, loadCat).map((item) => {
            return (
              <ListItem
                key={item.id}
                sx={style.item}
                onClick={() => navigate(`/recipes/${item.id}`)}
              >
                {item.name}
              </ListItem>
            );
          })}
      </List>
      <List sx={style.list}>
        {props.recipeView &&
          recipes &&
          recipes.map((item) => {
            return (
              <ListItem
                key={item.id}
                sx={style.item}
                onClick={() => navigate(`/recipe/${item.id}`)}
              >
                {item.name} || {item.totalCost}$
              </ListItem>
            );
          })}
      </List>
      {!props.recipeView && (
        <Button
          sx={style.btn}
          disabled={props.categories && props.categories.length < loadCat}
          onClick={() => setLoadCat((c) => c + 2)}
        >
          more
        </Button>
      )}
    </Box>
  );
};

export default ListComponent;
