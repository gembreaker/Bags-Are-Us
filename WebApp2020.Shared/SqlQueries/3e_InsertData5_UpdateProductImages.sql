﻿UPDATE ProductDetails SET ProductImage = 'Pale_Blue_Mini_Tassel_Tote_Bag.jpg' WHERE ProductCode = (SELECT ProductCode FROM ProductDetails WHERE ProductName = 'Dorothy Perkins Blue Midi Tassel Tote Bag');
UPDATE ProductDetails SET ProductImage = 'hype-forest-blossom-18l-backpack-multi-04.jpg' WHERE ProductCode = (SELECT ProductCode FROM ProductDetails WHERE ProductName = 'Hype Forest Blossom 18L Backpack - Multi');
UPDATE ProductDetails SET ProductImage = 'HYP-217-BAD-BPK-BUR.jpg' WHERE ProductCode = (SELECT ProductCode FROM ProductDetails WHERE ProductName = 'Hype Badge 18L Backpack - Burgundy');
UPDATE ProductDetails SET ProductImage = 'hype-neon-rose-18l-backpack-multi.jpg' WHERE ProductCode = (SELECT ProductCode FROM ProductDetails WHERE ProductName = 'Hype Neon Rose 18L Backpack - Multi');
UPDATE ProductDetails SET ProductImage = 'Fjallraven-Kanken-Bag-Sky-Blue.jpg' WHERE ProductCode = (SELECT ProductCode FROM ProductDetails WHERE ProductName = 'Fjallraven Kanken - Sky Blue');
UPDATE ProductDetails SET ProductImage = 'Fjallraven-Kanken-Pink.jpg' WHERE ProductCode = (SELECT ProductCode FROM ProductDetails WHERE ProductName = 'Fjallraven Kanken - Pink');
UPDATE ProductDetails SET ProductImage = 'oasis_black_backback.jpg' WHERE ProductCode = (SELECT ProductCode FROM ProductDetails WHERE ProductName = 'Oasis Black Large Zip Backpack');
UPDATE ProductDetails SET ProductImage = 'oasis_black_totebag.jpg' WHERE ProductCode = (SELECT ProductCode FROM ProductDetails WHERE ProductName = 'Oasis Black Oversized Tote Bag');