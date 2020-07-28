@Tags
Feature: Tags

  Scenario Outline: Test filters
    Given a parameter named <name>
    When testrun is started with filter
    Then the correct tests are executed
    
    @Something
    Examples: 
    |name     |
    |Something|
    
    @Different
    Examples:
    |name     |
    |different|
    