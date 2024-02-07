using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Inventory
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Inventory_Par_Count_DataType : INotifyPropertyChanged
	{
		private string par_Count_IDField;

		private LocationObjectType par_Location_ReferenceField;

		private Inventory_Par_Count_Line_DataType[] par_Count_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Par_Count_ID
		{
			get
			{
				return this.par_Count_IDField;
			}
			set
			{
				this.par_Count_IDField = value;
				this.RaisePropertyChanged("Par_Count_ID");
			}
		}

		[XmlElement(Order = 1)]
		public LocationObjectType Par_Location_Reference
		{
			get
			{
				return this.par_Location_ReferenceField;
			}
			set
			{
				this.par_Location_ReferenceField = value;
				this.RaisePropertyChanged("Par_Location_Reference");
			}
		}

		[XmlElement("Par_Count_Line_Data", Order = 2)]
		public Inventory_Par_Count_Line_DataType[] Par_Count_Line_Data
		{
			get
			{
				return this.par_Count_Line_DataField;
			}
			set
			{
				this.par_Count_Line_DataField = value;
				this.RaisePropertyChanged("Par_Count_Line_Data");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
