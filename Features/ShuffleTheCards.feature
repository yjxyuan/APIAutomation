Feature: Req001 - ShuffleTheCards
	Verify if Shuffle the Cards API is working as expected
	Simple calculator for adding two numbers

@Sanity @priority1
Scenario Outline: TC_ST_L1_ShuffleCards_P0001 - Add valid deck_count and/Or jokers_enabled query parameters to get shuffled cards
Given user shuffle <deck_count> deck of cards with <jokers_enabled>
Then success should be <success>, shuffled should be <shuffled>, remaining cards count should be <remaining>
Examples: 
| jokers_enabled| deck_count | success | shuffled | remaining |
| True          | 1          | True    | True     | 54        |
| False         | 1          | True    | True     | 52        |
| False         | 6          | True    | True     | 312       |
|               | 0		     | True    | True     | 0         |