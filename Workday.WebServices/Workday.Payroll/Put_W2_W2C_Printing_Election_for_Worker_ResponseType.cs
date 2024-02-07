using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Put_W-2_W-2C_Printing_Election_for_Worker_ResponseType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_W2_W2C_Printing_Election_for_Worker_ResponseType : INotifyPropertyChanged
	{
		private WorkerObjectType[] worker_with_Updated_W2_W2C_Print_Election_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Worker_with_Updated_W-2_W-2C_Print_Election_Reference", Order = 0)]
		public WorkerObjectType[] Worker_with_Updated_W2_W2C_Print_Election_Reference
		{
			get
			{
				return this.worker_with_Updated_W2_W2C_Print_Election_ReferenceField;
			}
			set
			{
				this.worker_with_Updated_W2_W2C_Print_Election_ReferenceField = value;
				this.RaisePropertyChanged("Worker_with_Updated_W2_W2C_Print_Election_Reference");
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
