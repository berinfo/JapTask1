import React, { useEffect } from "react";
import { useDispatch, useSelector } from "react-redux";
import { japActions } from "../store";
import axios from "axios";
import { Box, Typography } from "@mui/material";

import ListComponent from "./ListComponent";

const style = {
  heading: { textAlign: "center", fontSize: "25px" },
};

const Categories = () => {
  const categories = useSelector((state) => state.states.categories);
  const dispatch = useDispatch();

  useEffect(() => {
    async function getCategories() {
      //https://localhost:44305/Category/GetAll?skipData=0&limitData=2
      await axios
        .get(`https://localhost:5001/Categories`)

        .then((res) => {
          dispatch(japActions.setCategories(res.data.data));
        })
        .catch((err) => {
          console.log(err);
        });
    }
    getCategories();
    // eslint-disable-next-line
  }, []);
  return (
    <Box>
      <Typography sx={style.heading}>Latest categories:</Typography>
      <ListComponent categories={categories} />
    </Box>
  );
};

export default Categories;
