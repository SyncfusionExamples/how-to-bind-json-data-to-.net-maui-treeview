# how-to-bind-json-data-to-.net-maui-treeview
This repository demonstrates how to bind hierarchical JSON data to the .NET MAUI TreeView (SfTreeView) control. It provides a sample implementation that reads JSON data, maps it to data models, and binds it to the TreeView using the ItemsSource property and hierarchy descriptors for structured display.

## Sample

The Syncfusion® .NET MAUI TreeView enables you to bind data from a JSON file using the ItemsSource property. This demonstration will guide you through the process of binding JSON data to the TreeView.

STEP 1: Access the JSON file from the local folder and use StreamReader to read the data and return as an ObservableCollection property.
```csharp
private void GenerateSource()
{
    var assembly = typeof(MainPage).GetTypeInfo().Assembly;
    Stream stream = assembly.GetManifestResourceStream("MAUITreeView.Data.navigation.json");
    using (StreamReader sr = new StreamReader(stream))
    {
        var jsonText = sr.ReadToEnd();
        ImageNodeInfo = new ObservableCollection<Countries>();
        var MyArrayData = JsonConvert.DeserializeObject<List<Countries>>(jsonText);
        foreach (var data in MyArrayData)
        {
            ImageNodeInfo.Add(data);
        }
    }
}
```

STEP 2: Bind the JSON collection data to the ItemSource.
```xaml
<syncfusion:SfTreeView x:Name="treeView"
                       ItemHeight="25"
                       Indentation="20"
                       ExpanderWidth="25"                                
                       ItemsSource="{Binding ImageNodeInfo}"  
                       AutoExpandMode="RootNodesExpanded"
                       NodePopulationMode="Instant">
    <syncfusion:SfTreeView.HierarchyPropertyDescriptors>
        <treeviewengine:HierarchyPropertyDescriptor TargetType="{x:Type local:Countries}" ChildPropertyName="States"/>
        <treeviewengine:HierarchyPropertyDescriptor TargetType="{x:Type local:States}" ChildPropertyName="Cities"/>
    </syncfusion:SfTreeView.HierarchyPropertyDescriptors>
</syncfusion:SfTreeView>
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements).

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion® has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion® liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion®'s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion®'s samples.