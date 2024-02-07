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
	public class Inventory_Quick_Issue_WWS_DataType : INotifyPropertyChanged
	{
		private LocationObjectType inventory_Site_ReferenceField;

		private WorkerObjectType issue_To_ReferenceField;

		private Inventory_Quick_Issue_Line_DataType[] quick_Issue_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public LocationObjectType Inventory_Site_Reference
		{
			get
			{
				return this.inventory_Site_ReferenceField;
			}
			set
			{
				this.inventory_Site_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Site_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public WorkerObjectType Issue_To_Reference
		{
			get
			{
				return this.issue_To_ReferenceField;
			}
			set
			{
				this.issue_To_ReferenceField = value;
				this.RaisePropertyChanged("Issue_To_Reference");
			}
		}

		[XmlElement("Quick_Issue_Line_Data", Order = 2)]
		public Inventory_Quick_Issue_Line_DataType[] Quick_Issue_Line_Data
		{
			get
			{
				return this.quick_Issue_Line_DataField;
			}
			set
			{
				this.quick_Issue_Line_DataField = value;
				this.RaisePropertyChanged("Quick_Issue_Line_Data");
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
