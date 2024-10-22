// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Softdent2OpenDentalConversion.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\_Imports.razor"
using Softdent2OpenDentalConversion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\_Imports.razor"
using Softdent2OpenDentalConversion.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\Pages\ExpCodes.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\Pages\ExpCodes.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\Pages\ExpCodes.razor"
using Syncfusion.Blazor.Spinner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\Pages\ExpCodes.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\Pages\ExpCodes.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\Pages\ExpCodes.razor"
using Softdent2OpenDentalConversion.Context.Softdent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\Pages\ExpCodes.razor"
using Softdent2OpenDentalConversion.Models.Softdent;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ExpCodes")]
    public partial class ExpCodes : SharedCode
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Users\User\source\repos\Softdent2OpenDentalConversion\Softdent2OpenDentalConversion\Pages\ExpCodes.razor"
       

    // Create instances of the two numeric textboxes in order to better
    // be able to SET FOCUS.
    SfNumericTextBox<double?> numericTextBoxEplosionCode { get; set; }
    SfNumericTextBox<double?> numericTextBoxADACode { get; set; }

    // Blazor display variables for each numeric textbox.
    private double? explosionCode { get; set; } = 0;
    private double? adaCode { get; set; } = 0;

    // Variables for the page's DialogBox.
    private bool DialogBoxVisible { get; set; } = false;
    private string dialogBoxText { get; set; } = "";
    private string dialogBoxHeader { get; set; } = "System Message";

    // Explosion Code Grid and List instances.
    SfGrid<ExplosionCodes> Grid { get; set; }
    public List<Softdent2OpenDentalConversion.Models.Softdent.ExplosionCodes> GridData { get; set; }

    // DBContext for the Softdent database.
    SoftdentContext dbSoftdentContext = new SoftdentContext();

    // The selected row number and the table value of the column ID
    int rowIndex { get; set; } = 0;
    int recordID { get; set; } = 0;

    protected override void OnInitialized()
    {
        GridData = dbSoftdentContext.ExplosionCodes.OrderBy(e => e.ExplosionCode).ThenBy(e => e.ADACode).ToList();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await numericTextBoxEplosionCode.FocusIn();

        if (firstRender)
        {
            // Set the page title.
            await jsRuntime.InvokeVoidAsync("SetPageTitle", "Explosion Codes");

            // If the grid has records then highlight row 0.
            if (Grid.TotalItemCount > 0) await Grid.SelectRow(0);
        }
    }

    async Task ScrollGrid(int rowIndex)
    {
        await jsRuntime.InvokeAsync<object>("scroll", rowIndex);
        await numericTextBoxEplosionCode.FocusIn();

        // The value of x above is the Grid RowIndex to be selected.
        await Grid.SelectRow(rowIndex);
    }

    private void AddCode()
    {
        // Set a flag to decide to continue or break as this method progresses.
        bool _continue = true;

        if (explosionCode == 0)
        {
            // Do not continue if the Explosion Code value is zero.
            _continue = false;
            ShowModalDialogBox("Explosion Code cannot be zero!");
            numericTextBoxEplosionCode.FocusIn();
        }

        if (_continue && explosionCode < 1000000)
        {
            // Softdent Explosion Codes start at 1 million.
            _continue = false;
            ShowModalDialogBox("Explosion Codes must be greater than or equal to 1000000.");
            numericTextBoxEplosionCode.FocusIn();
        }

        if (_continue && adaCode == 0)
        {
            // Do not continue if the ADA Code value is zero.
            _continue = false;
            ShowModalDialogBox("ADA code cannot be zero!");
            numericTextBoxADACode.FocusIn();
        }

        if (_continue)
        {
            // Check to make sure the ADA Code is valid.
            bool validADACode = dbSoftdentContext.ADACodes.Where(e => e.CodeNumeric == Math.Floor((decimal)adaCode)).ToList().Count() > 0;
            if (!validADACode)
            {
                _continue = false;
                ShowModalDialogBox("Invalid ADA Code ...please re-enter.");
                numericTextBoxADACode.FocusIn();
            }
        }

        if (_continue)
        {
            // Check to see if the Explosion Code / ADA Code combination
            // already exists before adding.
            bool codesExist = dbSoftdentContext.ExplosionCodes.Where(e => e.ExplosionCode == (decimal)explosionCode)
                .Where(e => e.ADACode == (decimal)adaCode).ToList().Count() > 0;

            if (!codesExist)
            {
                // Add the new code combination.
                ExplosionCodes explosionCodes = new ExplosionCodes();
                explosionCodes.ExplosionCode = (decimal)explosionCode;
                explosionCodes.ADACode = (decimal)adaCode;
                dbSoftdentContext.Add(explosionCodes);
                dbSoftdentContext.SaveChanges();

                // Reload the table data to the grid.
                GridData = dbSoftdentContext.ExplosionCodes.OrderBy(e => e.ExplosionCode).ThenBy(e => e.ADACode).ToList();

                // Loop through the list until the newly added codes are located.
                int x = 0;
                foreach (var record in GridData)
                {
                    if (record.ExplosionCode == (decimal)explosionCode && record.ADACode == (decimal)adaCode) break;
                    x += 1;
                }

                // A Javascript routine to scroll to the selected grid row.
                ScrollGrid(x);

                StateHasChanged();
            }
            else
            {
                // Notify the user that the code combination already exists.
                string errorMessage = "The code combination of " + explosionCode.ToString() + " and " +
                    adaCode.ToString() + " already exists!";

                ShowModalDialogBox(errorMessage);
                numericTextBoxEplosionCode.FocusIn();
            }
        }
    }

    public void RowSelectHandler(RowSelectEventArgs<ExplosionCodes> args)
    {
        // Get the selected row of the grid along with the value of the table's
        // ID column after each mouse click.
        rowIndex = (int)args.RowIndex;
        recordID = args.Data.ID;
    }

    private void OnDialogBoxOverlayClick(MouseEventArgs args)
    {
        // Close the dialog box when the user clicks on it's close box.
        DialogBoxVisible = false;
    }

    private void ShowModalDialogBox(string message)
    {
        // Set the dialog box text and show.
        dialogBoxText = message;
        DialogBoxVisible = true;
    }

    private void DeleteHighlightedGridRecord()
    {
        // Find the current grid record in the SQL table and update.
        var expCode = dbSoftdentContext.ExplosionCodes.SingleOrDefault(e => e.ID == recordID);
        dbSoftdentContext.ExplosionCodes.Remove(expCode);
        dbSoftdentContext.SaveChanges();

        // Reload the table data to the grid.
        GridData = dbSoftdentContext.ExplosionCodes.OrderBy(e => e.ExplosionCode).ThenBy(e => e.ADACode).ToList();

        // Now that the record is deleted, set the selected row to rowIndex - 1 
        // unless there are no records, or the row is already at the top of the grid.
        if (rowIndex > 0) rowIndex -= 1;

        // Move to the currently selected row.
        ScrollGrid(rowIndex);

        // Update all visual components on the page.
        StateHasChanged();
    }

    private void OnContextMenuClick(ContextMenuClickEventArgs<ExplosionCodes> args)
    {
        switch (args.Item.Text)
        {
            // Custom methods to process when a context menu option is selected.
            case "Delete Record":
                DeleteHighlightedGridRecord();
                break;
        }
    }

    public void ActionBeginHandler(ActionEventArgs<ExplosionCodes> args)
    {
        if (args.RequestType.ToString() == "Save")
        {
            if (args.Action == "Edit")
            {
                //Cancel the default editing action in Grid 
                args.Cancel = true;

                // Get the current record in the SQL table and apply updates.
                var result = dbSoftdentContext.ExplosionCodes.SingleOrDefault(e => e.ID == recordID);
                result.ExplosionCode = args.Data.ExplosionCode;
                result.ADACode = args.Data.ADACode;
                dbSoftdentContext.Entry(result).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                dbSoftdentContext.SaveChanges();

                // Update the grid columns to reflext changes made in 
                // the dialog form.
                args.RowData.ExplosionCode = args.Data.ExplosionCode;
                args.RowData.ADACode = args.Data.ADACode;
            }
            else if (args.Action == "Add")
            {
                //Cancel the default add record action in Grid 
                args.Cancel = true;

                ShowModalDialogBox("Add Explosion Code logic goes here.");
            }

            // Close and refresh the grid to display changes.
            Grid.CloseEdit();
            Grid.Refresh();
        }
    }

    public void ActionCompleteHandler(ActionEventArgs<ExplosionCodes> args)
    {
        // Once the grid dialog edit form is closed, select and highlight
        // the current row.
        Grid.SelectRow(rowIndex);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
