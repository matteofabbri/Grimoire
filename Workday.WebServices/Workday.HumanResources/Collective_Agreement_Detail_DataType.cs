using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Collective_Agreement_Detail_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType assign_Employee_Collective_Agreement_Event_ReferenceField;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private DateTime end_Assignment_DateField;

		private bool end_Assignment_DateFieldSpecified;

		private Collective_Agreement_Snapshot_DataType[] collective_Agreement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Assign_Employee_Collective_Agreement_Event_Reference
		{
			get
			{
				return this.assign_Employee_Collective_Agreement_Event_ReferenceField;
			}
			set
			{
				this.assign_Employee_Collective_Agreement_Event_ReferenceField = value;
				this.RaisePropertyChanged("Assign_Employee_Collective_Agreement_Event_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime End_Assignment_Date
		{
			get
			{
				return this.end_Assignment_DateField;
			}
			set
			{
				this.end_Assignment_DateField = value;
				this.RaisePropertyChanged("End_Assignment_Date");
			}
		}

		[XmlIgnore]
		public bool End_Assignment_DateSpecified
		{
			get
			{
				return this.end_Assignment_DateFieldSpecified;
			}
			set
			{
				this.end_Assignment_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_Assignment_DateSpecified");
			}
		}

		[XmlElement("Collective_Agreement_Data", Order = 3)]
		public Collective_Agreement_Snapshot_DataType[] Collective_Agreement_Data
		{
			get
			{
				return this.collective_Agreement_DataField;
			}
			set
			{
				this.collective_Agreement_DataField = value;
				this.RaisePropertyChanged("Collective_Agreement_Data");
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
