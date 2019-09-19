# ConvertXMLToClass
App for convert XML-file with locators to Page Object class.

### Input file sample:
<pre>
&lt;Container name="Organization"&gt;
    &lt;Object&gt;
      &lt;label&gt;Organization&lt;/label&gt;
      &lt;type&gt;CPTextBox&lt;/type&gt;
      &lt;id&gt;NameTxt&lt;/id&gt;
    &lt;/Object&gt;
    &lt;Object&gt;
      &lt;label&gt;Parent Organization&lt;/label&gt;
      &lt;type&gt;CPPickList&lt;/type&gt;
      &lt;id&gt;ParentOrganization&lt;/id&gt;
    &lt;/Object&gt;
    &lt;Object&gt;
      &lt;label&gt;Organization Number&lt;/label&gt;
      &lt;type&gt;CPTextBox&lt;/type&gt;
      &lt;id&gt;OrganizationID&lt;/id&gt;
    &lt;/Object&gt;
&lt;/Container&gt;
</pre>

### Output sample
<pre>
public class Page 
{
    public CPTextBox Organization => new CPTextBox (By.Id("NameTxt"), this);
    public CPPickList ParentOrganization => new CPPickList (By.Id(ParentOrganization"), this);
    public CPTextBox OrganizationNumber => new CPTextBox (By.Id("OrganizationNumber"), this);
}

<code>
