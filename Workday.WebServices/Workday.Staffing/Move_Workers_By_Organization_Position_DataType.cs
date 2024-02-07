using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Move_Workers_By_Organization_Position_DataType : INotifyPropertyChanged
	{
		private Staffing_InterfaceObjectType position_to_Move_ReferenceField;

		private WorkerObjectType worker_for_Position_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Staffing_InterfaceObjectType Position_to_Move_Reference
		{
			get
			{
				return this.position_to_Move_ReferenceField;
			}
			set
			{
				this.position_to_Move_ReferenceField = value;
				this.RaisePropertyChanged("Position_to_Move_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public WorkerObjectType Worker_for_Position_Reference
		{
			get
			{
				return this.worker_for_Position_ReferenceField;
			}
			set
			{
				this.worker_for_Position_ReferenceField = value;
				this.RaisePropertyChanged("Worker_for_Position_Reference");
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
