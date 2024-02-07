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
	public class Union_Member_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private UnionObjectType union_ReferenceField;

		private DateTime seniority_DateField;

		private Union_Membership_DataType[] union_Membership_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public UnionObjectType Union_Reference
		{
			get
			{
				return this.union_ReferenceField;
			}
			set
			{
				this.union_ReferenceField = value;
				this.RaisePropertyChanged("Union_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Seniority_Date
		{
			get
			{
				return this.seniority_DateField;
			}
			set
			{
				this.seniority_DateField = value;
				this.RaisePropertyChanged("Seniority_Date");
			}
		}

		[XmlElement("Union_Membership_Data", Order = 3)]
		public Union_Membership_DataType[] Union_Membership_Data
		{
			get
			{
				return this.union_Membership_DataField;
			}
			set
			{
				this.union_Membership_DataField = value;
				this.RaisePropertyChanged("Union_Membership_Data");
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
