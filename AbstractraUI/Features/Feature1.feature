Feature: Shopping cart for your website



  @tag1
  Scenario: Consumer can add a product to the shopping cart
    Given I open "http://opencart.abstracta.us/"
    When I search for "iPhone"
    And I click on the first option
    And  I click on Add to Cart
    And I should see Success
    And I click on Shopping Cart
    And I click on View Cart
    And I should see iPhone
    And I click on Remove
    Then  I should not see iPhone
