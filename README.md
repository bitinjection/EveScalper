# EveScalper

C# program for finding securities to scalp on the market in Eve Online

## Scalping

Often misunderstood as "margin trading" in Eve Online, scalping in is the process of buying a security at the top bid
price and immediately relisting it at the lowest ask price.  The trader's profit, then, is the difference between
the ask and the bid prices, also known as the "spread."  Because most prices in Eve Online remain fairly constant and no automated trading is allowed,
this is likely the most common way to trade.

Much of the work in scalping lies in finding the best items to trade.  This program attempts to help find these items.

## Planned Features

The scope of this program will be tightly focused around this specific type of trading.

* Determine security spreads
* Determine percentage spreads
* Determine spreads with respect to volume
* Estimate security competition

Due to the reliance on third party APIs and the lack of any real time API into the game itself, much of this data will be
collected in a delayed and/or random fashion.  This program, as such, acts only to suggest areas of potential interest.
