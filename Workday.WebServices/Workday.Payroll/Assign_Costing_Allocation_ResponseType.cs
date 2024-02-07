using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Assign_Costing_Allocation_ResponseType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType assign_Costing_Allocation_Event_ReferenceField;

		private WorkerObjectType worker_ReferenceField;

		private Position_RestrictionsObjectType position_Restriction_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Assign_Costing_Allocation_Event_Reference
		{
			get
			{
				return this.assign_Costing_Allocation_Event_ReferenceField;
			}
			set
			{
				this.assign_Costing_Allocation_Event_ReferenceField = value;
				this.RaisePropertyChanged("Assign_Costing_Allocation_Event_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public Position_RestrictionsObjectType Position_Restriction_Reference
		{
			get
			{
				return this.position_Restriction_ReferenceField;
			}
			set
			{
				this.position_Restriction_ReferenceField = value;
				this.RaisePropertyChanged("Position_Restriction_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
